/* /Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int PositiveCount(int [] array)
{	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i]>0)
		{
			count ++;
		}
	}
	return count;
}

int [] GetArray(string text)
{
	Console.WriteLine(text);
	int [] result = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
	// string str1 = String.Split(" ", str);
	// string num =Int32.Parse(str1);
	// int size = num.Lenght;
	return result;	//должен вернуть массив
}

//Запрос чисел
int [] array = GetArray("Введите М чисел");
//Делаем массив из строки
int quantity = PositiveCount(array);
Console.WriteLine($"{String.Join(", ", array)} -> {quantity}");
