
int M1(int value)
{
int a = value/10;
int b = a%10;
return(b);
}
int val = new Random().Next(100,1000);
Console.WriteLine(val);
int c =M1(val);
Console.WriteLine(c);


