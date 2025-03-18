/* П"єса
using System;
class Program
{
    static void Main()
    {
        using (Play play1 = new Play("Гамлет", "Вільям Шекспір", "Трагедія", 1603))
        {
            play1.DisplayInfo();
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
class Play : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    private bool disposed = false;

    public Play(string Title, string Author, string Genre, int Year)
    {
        this.Title = Title;
        this.Author = Author;
        this.Genre = Genre;
        this.Year = Year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"П'єса: {Title}, Автор: {Author}, Жанр: {Genre}, Рік: {Year}");
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine($"Dispose: Закриття п'єси \"{Title}\".");
            }
            disposed = true;
        }
    }
    ~Play()
    {
        Dispose(false);
        Console.WriteLine($"Деструктор: Видалення п'єси \"{Title}\".");
    }
}
*/
//Магазин 
using System;
class Program
{
    static void Main()
    {
        using (Store store1 = new Store("АТБ", "Житомир, вул. Житомирська, 1", "Продовольчий"))
        {
            store1.DisplayInfo();
        }
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
class Store : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string StoreType { get; set; }
    private bool disposed = false;

    public Store(string name, string address, string storeType)
    {
        Name = name;
        Address = address;
        StoreType = storeType;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Магазин: {Name}, Адреса: {Address}, Тип: {StoreType}");
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine($"Dispose: Закриття магазину \"{Name}\".");
            }
            disposed = true;
        }
    }
    ~Store()
    {
        Dispose(false);
        Console.WriteLine($"Деструктор: Видалення магазину \"{Name}\".");
    }
}
