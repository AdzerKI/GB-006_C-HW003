/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

System.Console.Write("Введите 5-значное число: ");
string number = Console.ReadLine();

if(number.Length != 5 || !number.All(char.IsDigit)){
    System.Console.Write("Не 5-значное число");
} else {    
    if (number[0] == number[4] && number[1] == number[3]){
        System.Console.Write($"{number} - > да");
    } else {        
        System.Console.Write($"{number} - > нет");
    }
}


/* Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


// метод записи точки
void pointSave(int[] array, string str){
    for( int i = 0; i < 3; i++){
        // запись координат
        System.Console.Write($"Введите координату {i} точки {str}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// принимаем координаты первой точки
int[] pointOne = new int[3];
pointSave(pointOne, "1");

// принимаем координаты второй точки
int[] pointTwo = new int[3];
pointSave(pointTwo, "2");

// вычисляем расстояние
double distance = Math.Sqrt( Math.Pow((pointTwo[0] - pointOne[0]), 2) +
                             Math.Pow((pointTwo[1] - pointOne[1]), 2) + 
                             Math.Pow((pointTwo[2] - pointOne[2]), 2) );

System.Console.WriteLine($"А ({pointOne[0]}, {pointOne[1]}, {pointOne[2]}); " +
                         $"B ({pointTwo[0]}, {pointTwo[1]}, {pointTwo[2]}) " +
                         $"-> {distance}");


/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

System.Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{number} -> ");

for( int i = 1; i <= number; i++ ){
    int pow = Convert.ToInt32(Math.Pow(i, 3));
    System.Console.Write($"{pow}, ");
}