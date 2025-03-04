

//Завдання 3 (Структури)
/* using System;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Введіть десяткове число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            DecimalNumber decimalNumber = new DecimalNumber(number);
            Console.WriteLine($"Двійкова система: {decimalNumber.ToBinary()} ");
            Console.WriteLine($"Вісімкова система: {decimalNumber.ToOctal()} ");
            Console.WriteLine($"Шістнадцяткова система: {decimalNumber.ToHexadecimal()} ");
        }
        else
        {
            Console.WriteLine("Не коректне число! ");
        }
    }
    struct DecimalNumber 
    {
        private int num;
        public DecimalNumber(int num)
        {
            this.num = num;
        }
        public string ToBinary()
        {
            return Convert.ToString(num, 2);
        }
        public string ToOctal()
        {
            return Convert.ToString(num, 8);
        }
        public string ToHexadecimal()
        {
            return Convert.ToString(num, 16);
        }
    }
} */

/* Завдання 2 (ООП)
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        MusicalInstrument[] instrument = {new Violin(), new Tronbone(), new Ukulele(), new Cello() };
        foreach (var instruments in instrument)
        {
            instruments.Show();
            instruments.Desc();
            instruments.Sound();
            instruments.History();
            Console.WriteLine("-------");
        }
    }
    abstract class MusicalInstrument
    {
        protected string Name;
        protected string Characteristics;
        public MusicalInstrument(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }
        public abstract void Sound();
        public void Show() => Console.WriteLine($" Назва інструмента: {Name}");
        public void Desc() => Console.WriteLine($"Опис інструмента: {Characteristics}");
        public abstract void History();
    }
    class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка", "Струнний музичний смичковий інструмент.") { }
        public override void Sound() => Console.WriteLine("Скрипка — це музичний інструмент із прекрасним та емоційним звучанням, здатним переносником слухача у світ гармонії та мелодії.");
        public override void History() => Console.WriteLine("Прототипами скрипки були арабський ребаб і німецька рота, злиття яких і утворило віолу. Власне, італійська назва скрипки, violino, і є димінутивом від viola. Форми скрипки сформувались до XVI століття; в цьому столітті і на початку наступного, XVII, творили майстри скрипок сімейства Аматі.");
    }
    class Tronbone : MusicalInstrument
    {
        public Tronbone() : base("Тромбон", "Музичний інструмент сімейства мідних духових.") { }
        public override void Sound() => Console.WriteLine("Тромбон звучить потужно і глибоко.");
        public override void History() => Console.WriteLine("Тромбон з'явився в XV столітті і використовується в оркестрах та джазі.");
    }
    class Ukulele : MusicalInstrument 
    {
        public Ukulele() : base("Укулеле", "Чотириструнний різновид гітари, що використовується для акордового супроводу пісень та гри соло.") { }
        public override void Sound() => Console.WriteLine("Легке та веселе звучання.");
        public override void History() => Console.WriteLine("Укулеле з'явилася на Гавайських островах у другій половині ХІХ століття.");
    }
    class Cello : MusicalInstrument 
    {
        public Cello() : base("Віоланчель", "Віолончель використовують як сольний інструмент, групу віолончелей використовують у струнному та симфонічному оркестрах.") { }
        public override void Sound() => Console.WriteLine("Насиченний і виразний інструмент.");
        public override void History() => Console.WriteLine("Поява віолончелі сягає початку XVI століття.");
    }
}
*/


/*  Завдання 1 (ООП)
using System;
class Program
{
    static void Main() 
    {
        Money money = new Money(150, 30);
        Product product = new Product("Цукерки", money);

        product.Display();
        product.ReductPrice(1150);
        product.Display();
    }
}
class Money
{
    private int wholePart;
    private int cents;

    public Money(int wholePart, int cents)
    {
        SetMoney(wholePart, cents);
    }
    public void SetMoney(int wholePart, int cents)
    {
        if (wholePart < 0 || cents < 0)
            throw new ArgumentException("Сума не може бути відємною! ");

        this.wholePart = wholePart + cents / 100;
        this.cents = cents % 100;
    }
    public void Display()
    {
        Console.WriteLine($"{wholePart},{cents}");
    }
    public int WholePart => wholePart;
    public int Cents => cents;

}
class Product 
{
    private string name;
    private Money price;
    public Product(string name, Money price)
    {
        this.name = name;
        this.price = price;
    }
    public void ReductPrice(int amount) 
    {
        int allCents = price.WholePart * 100 + price.Cents - amount;
        if (allCents < 0)
            throw new ArgumentException();
        price = new Money(allCents / 100, allCents % 100);
    }
    public void Display() 
    {
        Console.WriteLine($"Товар: {name}, Ціна: ");
        price.Display();
    }
}
*/