
System.Random numSintezator = new System.Random();
//Вариант 1
int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;

if(firstNum>secondNum)
{
    Console.WriteLine(firstNum);
}
else
{
    Console.WriteLine(secondNum);
}
//Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
int firstNum = ((int)digits[0])-48;
int secondNum = ((int)digits[1])-48;
Console.WriteLine(digits);
