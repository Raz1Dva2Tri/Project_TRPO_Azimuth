using TRPO_Project_Azimuth_;

bool isRunning = true;

Console.WriteLine("Введите дирекционный угол:");
double number = 0 ;
double pn = 0;
string z = Console.ReadLine();
if (double.TryParse(z, out number)) number = double.Parse(z);

Console.WriteLine("Введите поправку направления:");
z = Console.ReadLine();
if (double.TryParse(z, out number)) pn = double.Parse(z);

Azimuth azimuth = new(number, pn);




while (isRunning)
{
    Console.Clear();
    Console.WriteLine("     Выберите пункт меню:");
    Console.WriteLine("1.   Вывести дирекционный угол");
    Console.WriteLine("2.   Вывести дирекционный угол в тысячных");
    Console.WriteLine("3.   Вывести обратный дирекционный угол в тысячных");
    Console.WriteLine("4.   Вывести дирекционный угол в MRLD");
    Console.WriteLine("5.   Вывести обратный дирекционный угол в MRLD");
    Console.WriteLine("6.   Вывести среднее сближение меридиан");
    Console.WriteLine("7.   Вывести поправку направления");
    Console.WriteLine("8.   Вывести обратный дирекционный угол");
    Console.WriteLine("9.   Вывести истинный Азимут");
    Console.WriteLine("10.  Вывести Магнитный Азимут");
    Console.WriteLine("11.  Прямая геодезическая задача");
    Console.WriteLine("0.   Выход");

    Console.Write("\nВведите номер пункта: ");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);

    switch (choice)
    {
        case 1:
            Console.WriteLine(azimuth.Ugl);
            break;
        case 2:
            Console.WriteLine(azimuth.Tysychnay_USSR_RUS); 
            break;
        case 3:
            Console.WriteLine(azimuth.Tysychnay_USSR_RUS_obr);
            break;
        case 4:
            Console.WriteLine(azimuth.MRLD);
            break;
        case 5:
            Console.WriteLine(azimuth.MRLD_obr);
            break;
        case 6:
            Console.WriteLine(azimuth.SSM);
            break;
        case 7:
            Console.WriteLine(azimuth.PN);
            break;
        case 8:
            Console.WriteLine(azimuth.ObrDirUgl);
            break;
        case 9:
            Console.WriteLine(azimuth.Geo_Azim);
            break;
        case 10:
            Console.WriteLine(azimuth.Mag_AziN);
            break;
        case 11:
            Console.WriteLine("Введите X:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            var y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дистанцию:");
            var dist = double.Parse(Console.ReadLine());
            var point = azimuth.PGZ(new Point(x,y), dist);
            Console.WriteLine();
            break;
        case 0:
            isRunning = false;
            break;
        default:
            Console.WriteLine("Неверный номер пункта. Повторите ввод.");
            Console.ReadKey();
            break;
    }
}