Console.Clear();
 
 Console.Write("Введи день недели цифрой: ");

int number = Convert.ToInt32(Console.ReadLine());

void Check (int number) 
{

  if (number == 6 || number == 7) 
  {
  Console.WriteLine("выходной!!!");
  }
  
  else if (number < 1 || number > 7) 
  {
    Console.WriteLine("что - то на эльфийском");
  }

  else Console.WriteLine("этот день не выходной, работать, кожаный");

}




Check(number);