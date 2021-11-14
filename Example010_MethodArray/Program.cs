// Найти позицию (index) числа 4, 18.

//      index   0   1  2   3   4   5  6   7
int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18};

int  n = array.Length;
// int find  = 4;
int find  = 18;
int index = 0;
// Если в массиве два одинаковых числа, 
//а нужно найти только первое по порядку число, 
//используем команду break - "прервать"
while (index < n)
{
    if(array[index] == find)
    {
       Console.WriteLine(index); 
       break;
    }
     index++;
}

