//Задача №26 Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
Console.WriteLine("write number");
int num=int.Parse(Console.ReadLine()??"0");
int count=0;
while(num>0)
{
    num/=10;
    count+=1;
}
Console.WriteLine(count);