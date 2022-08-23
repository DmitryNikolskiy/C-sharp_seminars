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
void ReverseArray(int [] arr)
{
    int temp = 0;
    for (int j = 0; j < arr.Length/2; j++)
    {
        temp = arr[j];
        arr[j] = arr[arr.Length - 1 - j];
        arr[arr.Length - 1 - j] = temp;
    }
}
int[] array = FillArray(ArraySize, leftRange, rightRange);
Console.WriteLine('[' + string.Join(", ", array) + ']');
ReverseArray(array);
Console.WriteLine('[' + string.Join(", ", array) + ']');