string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputNum != null)
{
    //Парсим введенное число
    int number = int.Parse(inputNum);

    // Находим квадрат числа
    int outNum = number*number;

    // Выводим данные в консоль
    Console.WriteLine(outNum);

    // Тоже самое в одну строчку
    Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}