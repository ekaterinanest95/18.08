//Задача 33: Задайте массив. 
//Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
//4 массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да

/*int[] array = new int[5];

for(int i = 0; i < array.Length; i++)
{
    array1[i] = new Random().Next(-10,20);
}

Console.WriteLine($"[{String.Join("; ", array)}]");*/





/*Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int size = 15;
int min = 1;
int max = 50;
string Result = "отсутствует";

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

bool FindNumber(int[] array, int Number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number) return true;
    }
    return false;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[] array = CreateArray(size, min, max);
PrintArray(array);
if (FindNumber(array, Number)) Result = "присутствует";
System.Console.WriteLine($"Число {Number} {Result} в массиве");
System.Console.WriteLine();
*/


Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];


for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,20);
}

Console.WriteLine($"[{String.Join("; ", array)}]");


for (int i = 0; i < array.Length; i++)
{
    if (array[i] == Number) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
    break;
}

// решение в классе
int[] testArray = {-2,-1,0,1,2};
int searchElement = Convert.ToInt32(Console.ReadLine());

string foundResult = "не найден"; // false - element not found
for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] == searchElement) 
    {
        foundResult = "найден"; // element found
        break;
    }
}
Console.WriteLine($"Элемент {searchElement}: {foundResult}");
// if (foundResult == "найден") Console.WriteLine($"Элемент {searchElement} присутствует ");
//  //foundResult == true => foundResult
// else Console.WriteLine($"Элемент {searchElement} ОТСУТСТВУЕТ ");

// еще один вариант вывода результатов
bool testNumber = false;
if (testNumber) System.Console.WriteLine("true"); // testNumber==true => testNumber
if(!testNumber) System.Console.WriteLine("false");// !testNumber => testNumber == false




    







