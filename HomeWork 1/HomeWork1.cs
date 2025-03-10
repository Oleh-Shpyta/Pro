//Завдання 1  Співробітник, Завдання 2 Город , Завдання 3 Кредитна Картка.

using System;
class Program 
{
    static void Main() 
    {
        Employer emp1 = new Employer("Oleh", 500);
        Employer emp2 = new Employer("Tetiana",  100);
        emp1 += 10;
        Console.WriteLine($"Зарпоаиа Олега після підвищення: {emp1.Salary}");

        City city1 = new City($"Kyiv", 2000);
        City city2 = new City($"Chudnov", 300);
        city1 += 1000;
        Console.WriteLine($"Населення Київа після збільшення: {city1.Population}");

        CreditCard card1 = new CreditCard($"400",  500, 50);
        CreditCard card2 = new CreditCard($"199",  0,50);
        card1 -= 12;
        Console.WriteLine($"Баланс Карти1 після відрахування: {card1.Balanse}");
    }
    class Employer
    { 
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employer(string name, decimal salary) 
        {
            Name = name;
            Salary = salary;
        }
        public static Employer operator +(Employer emp, decimal amount) 
        {
            emp.Salary += amount;
            return emp;
        }
        public static Employer operator -(Employer emp, decimal amount)
        {
            emp.Salary -= amount;
            return emp;
        }
        public static bool operator ==(Employer e1, Employer e2) => e1.Salary == e2.Salary;
        public static bool operator !=(Employer e1, Employer e2) => e1.Salary != e2.Salary;
        public static bool operator <(Employer e1, Employer e2)=> e1.Salary < e2.Salary;
        public static bool operator >(Employer e1, Employer e2) => e1.Salary > e2.Salary;

    }
    class City 
    { 
        public string Name { get; set; }
        public int Population { get; set; }
        public City(string name, int population) 
        {
            Name = name;
            Population = population;
        }
        public static City operator +(City city, int amount)
        {
            city.Population += amount;
            return city;
        }
        public static City operator -(City city, int amount)
        {
            city.Population -= amount;
            return city;
        }
        public static bool operator ==(City c1, City c2) => c1.Population == c2.Population;
        public static bool operator !=(City c1, City c2) => c1.Population != c2.Population;
        public static bool operator <(City c1, City c2) => c1.Population < c2.Population;
        public static bool operator >(City c1, City c2) => c1.Population > c2.Population;
    }
    class CreditCard
    {
        public string CardNumber { get; set; }
        public int CVC { get; set; }
        public decimal Balanse { get; set; }

        public CreditCard(string cardNumber, int cvc, decimal balanse)
        {
            CardNumber = cardNumber;
            CVC = cvc;
            Balanse = balanse;
        }
        public static CreditCard operator +(CreditCard card, decimal amount)
            {
                card.Balanse += amount;
                return card;
            }
        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card.Balanse -= amount;
            return card;
        }
        public static bool operator ==(CreditCard c1, CreditCard c2) => c1.CVC == c1.CVC ;
        public static bool operator !=(CreditCard c1, CreditCard c2) => c1.CVC != c1.CVC;
        public static bool operator <(CreditCard c1, CreditCard c2) => c1.Balanse < c2.Balanse;
        public static bool operator >(CreditCard c1, CreditCard c2) => c1.Balanse > c2.Balanse;
    }
}