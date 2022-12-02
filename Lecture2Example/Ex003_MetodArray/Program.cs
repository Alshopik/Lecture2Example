//Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

int [] array = {1, 12, 25, 54, 65, 24, 68, 54, 48};

int n = array.Length;
int find = 54;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
