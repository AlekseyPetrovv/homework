Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine()) ;
if(value%2==0)
{
Console.Write("Число: ");
Console.Write(value);
Console.Write(" чётное ");
}
else
{
Console.Write("Число: ");
Console.Write(value);
Console.Write(" не чётное ");
}