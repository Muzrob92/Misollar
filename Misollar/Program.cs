using System;

class Program
{
    static void Main()
    {
        // Darajaga ko'tarish
        double power = Math.Pow(2, 3);
        Console.WriteLine("2 ning 3-darajasi: " + power); // Natija: 8

        // Kvadrat ildiz
        double sqrt = Math.Sqrt(16);
        Console.WriteLine("16 ning kvadrat ildizi: " + sqrt); // Natija: 4

        // Modul
        double abs = Math.Abs(-5.5);
        Console.WriteLine("-5.5 ning absolyut qiymati: " + abs); // Natija: 5.5

        // Trigonometrik funksiyalar
        double sinValue = Math.Sin(Math.PI / 2); // 90 graduslik sinus
        Console.WriteLine("Sin(90 gradus): " + sinValue); // Natija: 1
    }
}
