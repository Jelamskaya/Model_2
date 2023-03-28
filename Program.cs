//Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел
//больше 0 ввел пользователь.
//0, 7, 8, -2, -2-> 2
//1, -7, 567, 89, 223 -> 3

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);  
    return result;
}
int[] InputArray(int length)
{
    int[] array =new int[length];
    for (int i = o; i< array.Length; i++)
    {
array[i] = Prompt($"Введите (i+1) элемент");
    }
    return array;
}
void PrintArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
{
    Console.WriteLine($"a[{i}] = {array[i]}");
}
}
int CountPositiveNambers(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
{
    if (array[i]>0)
{
    count++;
}
} 
return count;
}
int length = Prompt("ВВедиту кол-во элементов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Кол-во чисел > 0 = {CountPositiveNambers(array)}");


//Напишите пр-у, которая найдет точку пересечения двух прямых,
//заданными уранениями y=k1* x+ b1; y=K2* x + b2; значения b1, k1, b2,
//k2 задаются пользователем.
//b1=2, k1=5, b2=4, k2=9 ->(-0,5;-0,5)

const int COEFFICIETT = 0;
const int CONSTANT = 1;
const int x_COORD = 0;
const int y_COORD = 1;
const int Line1 = 1; 
const int Line2 = 2; 
double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);
if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FileNotFoundException Coords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[COEFFICENT]}*
    x + (lineData1[CONSTANT] и  y = {lineData2[COEFFICENT]}*
    x + (lineData2[CONSTANT])");
    console.WriteLine($"Имеет коор-ты ({COORD[x_COORD]}, 
    {coord[y_COORD]})");
}
double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[]InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
lineData[COEFFICENT] = Prompt($"Введите коэф для{numberOfLine}прямой >");
lineData[CONSTANT] = Prompt($"Введите константу для{numberOfLine}прямой >");
return lineData; 
}
double[] FindCOORDS(double[]lineData1,double[]lineData2)
{
   double[] COORD = new double[2]; 
   COORD[x_COORD]= (lineData1 [CONSTANT] - lineData2 [CONSTANT]/
   (lineData2 [COEFFICENT] - lineData1 [COEFFICENT]);
COORD[y_COORD]= lineData1 [CONSTANT] *COORD[x_COORD] +lineData1 [COEFFICENT];
return COORD; 
}
bool ValidateLines(double[]lineData1, double[]lineData2)
{
    if (lineData1 [COEFFICENT] == lineData2 [COEFFICENT]);
    if (lineData1 [CONSTANT] == lineData2 [CONSTANT]);
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
}
return true;
}