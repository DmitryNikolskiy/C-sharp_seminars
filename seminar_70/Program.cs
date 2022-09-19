string[] array = { "Hello!", "Seminar", "Sharp", "4", "15", "Good", "Hi!", ":-)" };
int i = 0;
int first = 0;
Console.Write("[");
while (i < array.Length)
{
    if(array[i].Length < 4)
    {
        Console.Write($"\"{array[i]}\"");
        first = i;
        break;
    }
    i++;
}
int j = first+1;
while (j < array.Length)
{
    if(array[j].Length < 4)
    {
        Console.Write($", \"{array[j]}\"");
    }
    j++;
}
Console.Write("]");