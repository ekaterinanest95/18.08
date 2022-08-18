// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[3];
int index = 0;
int length = array.Length;
int resultNegative = 0;
int resultPositive = 0;

while(index < length)
{
    array[index] = new Random().Next(-9,10); //зднсь отрицательное число не входит в границу
    if(array[index] < 0) resultNegative += array[index];
    else resultPositive += array[index];
    index++;
}

Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"sumPositive: {resultPositive}, SumNegative: {resultNegative}");



/*for(int i = 0; i < array.Length; i++)
{
    if(array[i] < 0) resultNegative += array[i];

}*/

