Console.WriteLine("Введите число a: ");
int value = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Введите число b: ");
int value2 = Convert.ToInt32(Console.ReadLine()) ;
if (value<value2)
{
Console.Write("Число ");
Console.Write(value);
Console.Write(" минимальное, число  ");
Console.Write(value2);
Console.WriteLine(" максимальное . ");
}
else
{
  Console.Write("Число ");
Console.Write(value2);
Console.Write(" минимальное, число  ");
Console.Write(value);
Console.WriteLine(" максимальное . ");  
}


