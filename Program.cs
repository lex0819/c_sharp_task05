/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Enter number of day from 1 to 7:");
string numberStr = Console.ReadLine() ?? "";

if(!int.TryParse(numberStr, out int number))
{
  Console.WriteLine($"invalid input");
  return;
};

string WeekDays(int number){

  if((number == 1) || (number == 2) || (number == 3) || (number == 4) || (number == 5))
  {
    Console.WriteLine($"{number} -> No");
    return "working day";
  }
  else if((number == 6) || (number == 7) )
  {
    Console.WriteLine($"{number} -> Yes");
    return "day off";
  }
  else{
    Console.WriteLine($"{number} is not any day of week");
    return "not a day";
  }
}

WeekDays(number);
