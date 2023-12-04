/*Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

void Print2DArray(int[,] inputArray){
    Console.WriteLine("Двумерный массив:");
    for (int i = 0; i < inputArray.GetLength(0); i++){
        for (int j = 0; j < inputArray.GetLength(1); j++){
            Console.Write(inputArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ElementValue(int[,] inputArray, int i, int j){
    if ((inputArray.GetLength(0) > i) && (inputArray.GetLength(1) > j)){
        Console.WriteLine($"Значение элемента [{i},{j}] - " + inputArray[i,j]);
    } else {
        Console.WriteLine("Такого элемента нет");
    }
}

int[,] array = new int[2,3];
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        array[i,j] = new Random().Next(1,10);
    }
}
Print2DArray(array);
Console.WriteLine("Введите позиции элемента в массиве");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
ElementValue(array,x,y);