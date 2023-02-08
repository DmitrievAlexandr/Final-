Console.WriteLine("Введите элементы массива через пробел ");
string text = Console.ReadLine();
if (text == "")
{
    Console.WriteLine("введенный массив пустой");
    Environment.Exit(0);
}
var inputArray = text.Split(' ');
string[] arrayNew = new string[inputArray.Length];
int j = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        arrayNew[j] = inputArray[i];
        j++;
    }
}
Array.Resize(ref arrayNew, j);
Console.WriteLine("полученный массив : " + string.Join(",", arrayNew));
