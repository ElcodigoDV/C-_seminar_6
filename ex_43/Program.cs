/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

float YLineCross(float x, float k1, float b1)
{
	float y = k1 * x + b1;
	return y;
}

float XPointCross (float k1, float b1, float k2, float b2)
{
	float x = (b2 - b1)/(k1-k2);
	return x;
}

float [] GetCoordinate (string text)
{
	Console.WriteLine(text);
    float [] result = Console.ReadLine().Split(",").Select(float.Parse).ToArray();
	return result;
}

// ввод данных пользователем
float [] coordinate = GetCoordinate ("введите числа через зпт");

float b1 = coordinate[0];
float k1 = coordinate[1];
float b2 = coordinate[2];
float k2 = coordinate[3];

// решение уравнения
float x = XPointCross(k1, b1, k2, b2);
float y = YLineCross(x, k1, b1);

Console.WriteLine($"b1={b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} - > ({x};{y})");
