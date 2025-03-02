using System;
class Program 
{
    static void Main(string[] args) 
    {
        float one, two, result;
        char sign;

        Console.WriteLine("Добро пожалувати в Калькулятор");
        Console.WriteLine("Введіть перше число: ");
        one = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Ввдіть знак (+, -, *, /): ");
        string input = Console.ReadLine();
        if (input.Length == 1)
        {
            sign = input[0];
        }
        else 
        {
            Console.WriteLine("Не коректно введений знак! ");
            return;
        }
            Console.WriteLine("Введіть друге число: ");
        two = Convert.ToSingle(Console.ReadLine());

        switch (sign) 
        {
            case '+': result = one+ two ;
                Console.WriteLine($"Сума ваших чисел дорівнює: {result} ");
            break;

            case '-':
                result = one - two;
                Console.WriteLine($"Різниця ваших чисел дорівнює: {result} ");
            break;

            case '*':
                result = one * two ;
                Console.WriteLine($"Множення ваших чисел дорівнює: {result} ");
            break;

            case '/':
                if (two == 0)
                    Console.WriteLine("Ділити на 0 неможливо! ");

                else
                {
                    result = one / two;
                    Console.WriteLine($"Ділення ваших чисел дорівнює: {result} ");
                }
            break;
        default: Console.WriteLine("Ви ввели недопустимий символ! ");
                Console.WriteLine("Для виходу настисніть будь-яку клавішу ");
                break;

        }

    }
}