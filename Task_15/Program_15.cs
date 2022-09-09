// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите цифру, соответствующую номеру дня недели(от 1 до 7)");
        int DayNumber = Convert.ToInt32(Console.ReadLine());

        void VerifyTheDay(int day)
        {
            if (day >= 1 && day <= 5)
            {
                Console.WriteLine("Этот день не выходной");
            }
            else if (day == 6 || day == 7)
            {
                Console.WriteLine("Этот день выходной");
            }
            else
            {
                Console.WriteLine("Введённое число вне диапазона");
            }
        }
        VerifyTheDay(DayNumber);
    }
}