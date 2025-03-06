//Звдання 1: IOutput, Завдання 2: IMath, Завдання 3 ISort!

using System;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        MyArray num = new MyArray(new int[] { 5, 4, 6 });
        num.Show();
        num.Show("Масив чисел");

        Console.WriteLine($"Максимум: {num.Max()}");
        Console.WriteLine($"Мінімум: {num.Min()}");
        Console.WriteLine($"Середнє значення: {num.Avg()}");
        Console.WriteLine($"Число 2 знайдено? {num.Search(2)}");

        num.SortAsc();
        num.Show("Сортування масиву за Зростанням: ");

        num.SortDesc();
        num.Show("Сортування масиву за Спаданням: ");

        num.SortByParam(true);
        num.Show("параметр true - Зростання ");
        num.SortByParam(false);
        num.Show("параметр false - Спаданням ");

    }
    interface IOutput
    {
        void Show();
        void Show(string info);
    }
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    interface ISort 
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    class MyArray : IOutput, IMath, ISort
    {
        private int[] array;
        public MyArray(int[] num)
        {
            array = num;
        }
        public void Show()
        {
            Console.WriteLine(string.Join("", array));
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
        public int Max()
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Масив пустий");
            return array.Max();
        }
        public int Min()
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Масив пустий");
            return array.Min();
        }
        public float Avg()
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Масив пустий");
            return (float)array.Average();
        }
        public bool Search(int valueToSearch)
        {
            return array.Contains(valueToSearch);
        }
        public void SortAsc() 
        {
            Array.Sort(array);
        }
        public void SortDesc() 
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
        public void SortByParam(bool isAsc) 
        {
            if (isAsc)
                SortAsc();
            else
                SortAsc();
        }
    }
}
