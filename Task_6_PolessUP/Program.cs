//Реализуйте метод, который определяет для данного года, является ли он високосным.
//Ввод: 2000
//Вывод: true
//Ввод: 2015
//Вывод: false

static void highAxisYear ()
{

    bool result = false;
    DateTime dateTime = DateTime.Now;
    int year = dateTime.Year;
    Console.WriteLine(year);
    if (year % 4 == 0)
    {
        result = true;
    }
    Console.WriteLine(result);
}

highAxisYear ();