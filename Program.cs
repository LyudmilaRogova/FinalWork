// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Метод, определяющий длину массива из строк, длина которых <= 3 символа
int NumberOfElements(string[] array){
    int size = 0;
    for(int i=0; i<array.Length; i++){
        if (array[i].Length <= 3) size += 1;
    }
    return size;
}

//Метод, формирующий массив из строк, длина которых <= 3 символа
string[] CreateResultArray(int size, string[] array){
    string[] resultArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            resultArray[j] = array[i];
            j += 1;
        }
    }
    return resultArray;
}

// Вывод массива на консоль
void PrintArray(string[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        if (i == array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}


string[] array = {"Hello", "2", "world", ":-)"}; // Объявление первоначального массива
PrintArray(array);
Console.WriteLine();

int size = NumberOfElements(array);
string[] resultArray = CreateResultArray(size, array);
PrintArray(resultArray);

