/*Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
Под удалением понимается создание нового двумерного массива без строки и столбца*/

void Print2DArray(int[,] inputArray){
    for (int i = 0; i < inputArray.GetLength(0); i++){
        for (int j = 0; j < inputArray.GetLength(1); j++){
            Console.Write(inputArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[] FindMinElement(int[,] inputArray){
    int[] minIndex = {0,0};
    int minValue = inputArray[minIndex[0],minIndex[1]];
    for (int i = 0; i < inputArray.GetLength(0); i++){
        for (int j = 0; j < inputArray.GetLength(1); j++){
            if (minValue > inputArray[i,j]){
                minIndex[0] = i;
                minIndex[1] = j;
                minValue = inputArray[i,j];
            } 
        }
    }
    Console.WriteLine("Индекс первого минимального элемента - " + minIndex[0] + "," + minIndex[1]);
    return minIndex;
}

void RemoveLines(int[,] inputArray, int[] inputIndex){
    int [,] outputArray = new int[inputArray.GetLength(0)-1,inputArray.GetLength(1)-1];
    int x = 0;
    int y;
    for (int i = 0; i < inputArray.GetLength(0); i++){
        if (inputIndex[0] != i){
            y = 0;
            for (int j = 0; j < inputArray.GetLength(1); j++){
                if (inputIndex[1] != j){
                    outputArray[x,y] = inputArray[i,j];
                    y++;
                }
            }
            x++;
        }
    }
    Console.WriteLine("Новый массив:");
    Print2DArray(outputArray);
}

int[,] Fill2DArray(int arrayLengthX, int arrayLengthY){
    int[,] result = new int[arrayLengthX,arrayLengthX];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            result[i,j] = new Random().Next(1,10);
        }
    }
    Console.WriteLine("Двумерный массив:");
    Print2DArray(result);
    return result;
}


int[,] array = new int[3,3];
array = Fill2DArray(array.GetLength(0),array.GetLength(1));
int[] index = FindMinElement(array);
RemoveLines(array,index);