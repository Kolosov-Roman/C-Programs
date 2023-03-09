
Console.WriteLine("Здравствуйте. Добро пожаловать в конвертер. Что хотите сконвертировать?\n" +
    "\n" +
    "1. Доллары в рубли\n" +
    "2. Рубли в доллары\n" +
    "\n" +
    "Выберите 1 пункт из двух.\n" +
    "");

double c;
double a;

c = Convert.ToDouble(Console.ReadLine());

if (c == 1)
{
    Console.WriteLine("\n" +
        "Введите количество долларов.\n");
    c = Convert.ToDouble(Console.ReadLine());
    a = 56 * c;
    Console.WriteLine(a + " рублей.");
}
else if (c == 2)
{
    Console.WriteLine("\n" +
        "Введите количество рублей.\n");
    c = Convert.ToDouble(Console.ReadLine());
    a = c / 56;
    Console.WriteLine(a + " долларов.");
}
else
{
    Console.WriteLine("Выберите пункт 1 или 2.");
    Console.WriteLine("ВВЕДИ 1 ИЛИ 2 ИДИОТА КУСОК");

    Console.WriteLine("НЕ НУЖНО ВВОДИТЬ 3 ИЛИ 4 ИЛИ БУКВЫ");
}



//int a;
//int b;
//a = int.Parse(Console.ReadLine());

//if (b == a / 2)
//{
//    Console.WriteLine("Число а - чётное.");
//}
//else
//{
//    Console.WriteLine("Число а - нечётное.");
//}