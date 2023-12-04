/*Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */

void Print2DArray(int[,] inputArray){
    for (int i = 0; i < inputArray.GetLength(0); i++){
        for (int j = 0; j < inputArray.GetLength(1); j++){
            Console.Write(inputArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SwapLines(int[,] inputArray){
    int temp;
    for (int i = 0; i < inputArray.GetLength(1); i++){
        temp = inputArray[0,i];
        inputArray[0,i] = inputArray[inputArray.GetLength(0) - 1,i];
        inputArray[inputArray.GetLength(0) - 1,i] = temp;
    }
    Print2DArray(inputArray);
}

int[,] array = new int[5,4];
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        array[i,j] = new Random().Next(1,10);
    }
}
Console.WriteLine("Двумерный массив:");
Print2DArray(array);
Console.WriteLine("Двумерный массив после замены первой и последней строки:");
SwapLines(array);
