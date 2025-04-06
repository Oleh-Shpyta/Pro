using System;
using System.Text;
class Progtam 
{
    static void Main() 
    {
        Console.OutputEncoding = Encoding.UTF8;

        var shop = new BarberShop(3);
        var barberThread = new Thread(shop.Barber);
        barberThread.Start();

        for (int i = 1; i <= 20; i++)
        {
            int customerId = i;
            new Thread(() => shop.Customer(customerId)).Start();
            Thread.Sleep(new Random().Next(600, 1200));
        }
    }
}
class BarberShop
{
    private readonly int waitingRoomSize;
    private readonly Queue<int> waitingRoom;
    private readonly Semaphore customers;
    private readonly Semaphore barber;
    private readonly object syncLock = new();
    private bool isBarberSleeping = true;
    public BarberShop(int waitingRoomSize)
    {
        this.waitingRoomSize = waitingRoomSize;
        waitingRoom = new Queue<int>();
        customers = new Semaphore(0, waitingRoomSize);
        barber = new Semaphore(0, 1);
    }
    public void Barber()
    {
        while (true)
        {
            Console.WriteLine("Перукар спить...");
            customers.WaitOne();
            lock (syncLock)
            {
                isBarberSleeping = false;
            }
            int customer;
            lock (syncLock)
            {
                customer = waitingRoom.Dequeue();
            }
            Console.WriteLine($"Перукар стриже клієнта {customer}...");
            Thread.Sleep(1000);
            Console.WriteLine($"Клієнт {customer} пострижений.");
            barber.Release();
        }
    }
    public void Customer(int id)
    {
        lock (syncLock)
        {
            if (waitingRoom.Count >= waitingRoomSize)
            {
                Console.WriteLine($"Клієнт {id} пішов – немає вільних місць у приймальні.");
                return;
            }
            waitingRoom.Enqueue(id);
            Console.WriteLine($"Клієнт {id} чекає у приймальні.");
        }
        customers.Release();
        barber.WaitOne();
    }
}