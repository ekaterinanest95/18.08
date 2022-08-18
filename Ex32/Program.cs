//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array1 = new int[4]; 
int[] array2 = new int[4]; 

for(int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(-10,20);
}

Console.WriteLine($"[{String.Join("; ", array1)}]");


for(int i = 0; i < array2.Length; i++)
{
    array2[i] = -array1[i];
}

Console.WriteLine($"[{String.Join("; ", array1)}] -> [{String.Join("; ", array2)}]");





