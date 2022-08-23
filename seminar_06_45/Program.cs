const int ArraySize = 5;
const int leftRange = -10;
const int rightRange = 10;

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange+1);
    }
    return arr;
}

int[] array = FillArray(ArraySize, leftRange, rightRange);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int[] CopyArray = new int[array.Length];
for (int j = 0; j < array.Length; j++)
{
    CopyArray[j] = array[j];
        
}

Console.WriteLine('[' + string.Join(", ", CopyArray) + ']');