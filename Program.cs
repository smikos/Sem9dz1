int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void func (int a,int b =0)
{
 if (a>b)
 {
    return;
 }
 if (a%2==0)
 {
 System.Console.WriteLine(a);
 }
 func(a+1,b);
}
int a = ReadInt("введите число");
int b = ReadInt("введите число");
func (a,b);