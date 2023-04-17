//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



Console.WriteLine("Введите строки через пробел: ");
string userString = Console.ReadLine();
string[] userArray = userString.Split(' ');
Console.WriteLine("Ваш массив: ");
PrintArray (userArray);
Console.WriteLine();
Console.WriteLine("Введите длину (количество символов) искомых строк: ");
int maxStringLenght = Convert.ToInt32(Console.ReadLine());
string[] newArray = GetArrayThreeSymbolsString(userArray, maxStringLenght);
Console.WriteLine($"Массив строк из {maxStringLenght} символов и менее: ");
PrintArray (newArray);


string[] GetArrayThreeSymbolsString(string[] arr, int num)
		{
			int length = arr.Length;			
			string[] threeSymbolsString = new string[length];
			int count = 0;
			
			for (int i = 0; i < length; i++)
			{
				if(arr[i].Length <= num)
				{
					threeSymbolsString[count] = arr[i];
					count++;
				}
			}
			Array.Resize(ref threeSymbolsString, count);
			
			return threeSymbolsString;
		}
		
		
void PrintArray (string[] arr)
{   if(arr.Length == 0)
			{
				Console.WriteLine("Таких строк в массиве нет");
			}
	else
    {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    }
}

