void FillArray(int[] collection);//дан массив целых чисел, под названием "collection"
{
    int length = collection.Length; //длина = длине массива "collection"
    int index = 0;
    while (index < length) //пока индекс элемента < длины массива
    {
        collection[index] = new Random().Next(1, 10); //элемент - новое рандомное число от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
         Console.WriteLine(col[position]);
         position++;
    }

}
// int[] array = new int[10]; // Создай новый массив, в котором 10 элементов

// FillArray(array);
// PrintArray(array);

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;//если в массиве нет заданного числа, то чтобы это распознать вводят: int position = -1

    while (index < count)
    {
        if(collection[index]) == find)
        {
        position = index;
        break;
        }
         index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);