//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите число ");
int number = int.Parse(System.Console.ReadLine());
string number1 = number.ToString();
int len = number1.Length;

int [] array = new int [len];
for(int i = 0; i < len; i++)
{
    array[i] = int.Parse(number1[i].ToString());
}

for(int i = 0; i < len; i++ )
{
    System.Console.Write(array[i]);
}