/* See https://aka.ms/new-console-template for more information
Console.Write("Введите число:");
string myString = Console.ReadLine();
Console.WriteLine("{0}  {1}  {2}", 7, 15, 100);
*/
int execute;
do{
    Console.WriteLine("Добро пожаловать в песочницу Эгоиста. Выберите номер задачи с сайта https://c-sharp.pro/s2-вычисления-по-известным-формулам/ для проверки(S2.# писать не нужно). /n Для выходы из программы введите 0");
    Console.WriteLine();
    ReadInt("", out execute);


    switch (execute){
   
        case 1: 
        //Задача 2.1
        //a)
        ReadDouble("Введите значение х: ", out double x);
        double y = 7* Math.Pow(x,2) + 3*x + 6;
        Console.WriteLine("7x^2+3x+6="+ y +", при х равном "+x);
        //b)
        ReadDouble("Введите значение a: ", out double a);
        double b = 12* Math.Pow(a,2) + 7*a + 12;
        Console.WriteLine("12a^2+7a+12="+b+", при а равном "+a);

        Exiting();

        break;


        case 2:
        //Задача 2.2
        ReadDouble("Введите сторону квадрата", out double squareSide);
        Console.WriteLine("Периметр Вашего квадрата равен: " + squareSide*4);
    
        Exiting();

        break;

        case 3:
        //Задача 2.3
        ReadDouble("Введите радиус окружности: ", out double circleRadius);
        Console.WriteLine("Диаметр Вашей окружности равен: " + circleRadius * 2);

        Exiting();

        break;

    
        case 4:
        //Задача 2.4
        const double earthRadius = 5350;
        double heigtOfPoint, distanceBetween;

        ReadDouble("Введите высоту точки: ", out heigtOfPoint);
        distanceBetween = Math.Sqrt(Math.Pow(earthRadius + heigtOfPoint, 2) - Math.Pow(earthRadius, 2)); 

        Exiting();

        break;

        case 5:
        //Задача 2.5
        ReadDouble("Введите длину ребра куба: ", out double cubeEdge);
        double cubeVolume = Math.Pow(cubeEdge, 3);
        double cubeSidesSquare = 6 * Math.Pow(cubeEdge,2);
        Console.WriteLine("Объем заданного куба равен: {0}; Площадь поверхности заданного куба равна: {1}", cubeVolume, cubeSidesSquare); 
        
        Exiting();

        break;

        case 6:
        //Задача 2.6
        ReadDouble("Введите радиус окружности: ", out circleRadius);
        double circleLenght = Math.PI* 2 * circleRadius;
        double circleSquare = Math.PI*Math.Pow(circleRadius, 2);
        Console.WriteLine("Длина окружности равна: {0}; Площадь окружности равна: {1}", circleLenght, circleSquare);
        
        Exiting();

        break;

        case 7:
        //Задача 2.7
        ReadInt("Введите первое число: ", out int firstNumber);
        ReadInt("Введите второе число: ", out int secondNumber);
        int avgArif = (firstNumber + secondNumber) / 2;
        double avgGeom = Math.Sqrt(firstNumber * secondNumber);
        Console.WriteLine("Среднее арифметическое Ваших чисел равно: {0}; Среднее геометрическое Ваших чисел равно: {1}");
        
        Exiting();

        break;

        case 8:
        //Задача 2.8
        ReadDouble("Введите объем вещества: ", out double objVolume);
        ReadDouble("Введите массу вещества", out double objWeight);
        double objDensity = objWeight / objVolume;
        Console.WriteLine("Плотность вещества равна: " + objDensity);
        
        Exiting();

        break;

        case 9:
        //Задача 2.9
        ReadDouble("Введите численность населения государства: ", out double countryCitizensCount);
        ReadDouble("Введите площадь государства: ",out double countrySquare);
        double countryCitizensDensity = countryCitizensCount / countrySquare;
        Console.WriteLine("Плотность населения страны равна: " + countryCitizensDensity);
        
        Exiting();
        
        break;

        case 10:
        //Задача 2.10
        Console.WriteLine("Добро пожаловать в программу решения линейных уравнений типа ax+b=0, где a!=0");
        do{
            ReadDouble("Введите значение a: ", out a);
        }while (a==0);
        ReadDouble("Введите значение b: ", out b);

        x = (0 - b)/a;
        Console.WriteLine("Значение х равно: " + x);

        Exiting();

        break;

        case 11:
        //Задача 2.11
        ReadDouble("Введите первый катет: ", out double firstCathetus);
        ReadDouble("Введите второй катет: ", out double secondCathetus);

        Console.WriteLine("Гипотенуза треугольника равна: " + Math.Sqrt(Math.Pow(firstCathetus,2) + Math.Pow(secondCathetus, 2)));

        Exiting();
        break;
    }
    
}while (execute != 0);
Console.WriteLine("Спасибо за внимание! Удачного дня!");
Exiting();


void ReadDouble(string massege, out double x){
    Console.Write(massege);
    double.TryParse(Console.ReadLine(), out double x1);
    x = x1;
}

void ReadInt(string massege, out int x){
    Console.Write(massege);
    int.TryParse(Console.ReadLine(), out int x1);
    x = x1;
}

void Exiting(){

    Console.Write("Для продолжения нажминте Enter");
    Console.ReadLine();
    Console.Clear();
}