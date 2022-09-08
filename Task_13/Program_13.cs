// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);

void FindThirdDigit (string AnyNumber)
{
    if (AnyNumber.Length > 2)
        {
            Console.WriteLine ("Третья цифра " + AnyNumber[2]);
        }
    else
        {
            Console.WriteLine ("Третьей цифры нет");
        }
}
FindThirdDigit(NumberText);
