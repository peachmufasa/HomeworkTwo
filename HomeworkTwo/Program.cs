using System;

namespace HomeworkTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое Ф.И.О.");
            string fullName = Console.ReadLine();

            Console.WriteLine("Введите свой возраст");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите свой email");
            string email = Console.ReadLine();

            Console.WriteLine("Введите свой балл по программированию");
            float programmingScore = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите свой балл по математике");
            float mathScore = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите свой балл по физике");
            float physicsScore = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Вы ввели: \nФ.И.О.: {fullName} \nВозраст: {age} \nemail: {email} \nБалл по программированию: {programmingScore} \nБалл по математике: {mathScore} \nБалл по физике: {physicsScore}");

            float scoreSum = programmingScore + mathScore + physicsScore;
            float scoreAverage = (programmingScore + mathScore + physicsScore) / 3;

            Console.WriteLine($"Ваш общий балл: {scoreSum} \nВаш средний балл: {scoreAverage}");
            Console.ReadKey();

        }
    }
}
