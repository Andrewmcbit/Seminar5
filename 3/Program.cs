/*Задача 3: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

void Print2DArray(int[,] inputArray){
    for (int i = 0; i < inputArray.GetLength(0); i++){
        for (int j = 0; j < inputArray.GetLength(1); j++){
            Console.Write(inputArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FindLineIndex(int[,] inputArray){
    int[] minSum = new int[inputArray.GetLength(0)];
    Array.Fill(minSum,0);
    int minIndex = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++){
        for (int j = 0; j < inputArray.GetLength(1); j++){
            minSum[i] += inputArray[i,j]; 
        }
    }
    for (int i = 1; i < minSum.Length; i++){
        if (minSum[minIndex] > minSum[i]){
            minIndex = i;
        }
    }
    Console.WriteLine(minIndex);
}

int[,] array = new int[3,5];
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        array[i,j] = new Random().Next(1,10);
    }
}
Console.WriteLine("Прямоугольный двумерный массив:");
Print2DArray(array);
Console.Write("Индекст строки с минимальной суммой - ");
FindLineIndex(array);