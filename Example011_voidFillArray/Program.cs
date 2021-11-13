void FillArray (int[]collection);
{
    int Length = collection.Length;
    int index = 0;
    while(index<Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
int[]array = new int(10);

Console.WriteLine("Collection[index]");