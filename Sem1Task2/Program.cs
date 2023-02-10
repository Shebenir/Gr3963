// Задача №3
// Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру

Console.Write("Введите число");
var day = Convert.ToInt32(Console.ReadLine());

if(day > 8)
{
    day = day % 8;
}

string[] dayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(dayWeek[day-1]);

//В одну линию 
string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));