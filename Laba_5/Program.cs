using System;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Random rnd = new Random();

            Console.Write("Введіть довжину масивів х, у i z: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[a];
            int[] y = new int[a];
            int[] z = new int[a];

            //Заповнення(заповнення рандомними числами) і вивід масиву х
            for (int i = 0; i < x.Length; i++)
                x[i] = rnd.Next(-20, 20);

            Console.WriteLine("Масив x ");
            for (int i = 0; i < x.Length; i++)
                Console.Write(x[i] + ", ");


            Console.WriteLine(' ');


            //Заповнення(заповнення рандомними числами) і вивід масиву у
            for (int i = 0; i < y.Length; i++)
                y[i] = rnd.Next(-20, 20);

            Console.WriteLine("Масив у:");
            for (int i = 0; i < y.Length; i++)
                Console.Write(y[i] + ", ");

            Console.WriteLine(" \n ");

            Console.WriteLine("Завдання 1. Збільшити парні елементи масиву х вдвічі" + "\n");

            //Перебираємо елементи масиву, і кожен парний елемент збільшуємо вдвічі
            for (int i = 1; i < x.Length; i += 2)
                x[i] *=2 ;

            Console.WriteLine("Масив х зі збільшеними елементами: ");
            for (int i = 0; i < x.Length; i++)
                Console.Write(x[i] + ", ");


            Console.WriteLine(" \n ");


            Console.WriteLine("Завдання 2. Заповнити масив z, елементи якого є добутком елементів з такимиж індексами із масивів х і у" + "\n");
            //Заповнення масиву z
            for (int i = 0; i < z.Length; i++)
                z[i] = x[i] * y[i];

            Console.WriteLine("Масив z:");
            for (int i = 0; i < z.Length; i++)
                Console.Write(z[i] + ", ");
        }
    }
}
