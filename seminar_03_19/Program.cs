Console.WriteLine("Введите пятизначное число");
int number5 = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(Math.Abs(number5));
int[] array = new int [5];
int i=0;
while (i < 5)
{
    array[i] = int.Parse(number[i].ToString());
    i++;
}
if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Число - палиндром");
}
else
{ 
   Console.WriteLine("Число - не палиндром"); 
}