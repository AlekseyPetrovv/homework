Console.WriteLine("Введите число a: ");
int value = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Введите число b: ");
int value2 = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Введите число c: ");
int value3 = Convert.ToInt32(Console.ReadLine()) ;

int max = value;
if(max<value2)
{
 if(value2>value3)
 {
    max=value2;
 }
 else{
    max=value3;
 }
}
else
{
   if (max < value3)
   {
    max=value3;
   }
   else{
    max=max;
   }
}
Console.Write("максимальное число : ");
Console.Write(max);