Console.WriteLine("Input array length");
int array_length = Convert.ToInt32(Console.ReadLine());

string[] array = new string[array_length];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Input array");
    array[i] = Console.ReadLine();
}


string[] Array_clone = new string[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
    Array.Resize(ref Array_clone, Array_clone.Length + 1);
    Array_clone[Array_clone.Length - 1] = array[i];
    }
}
var str = string.Join(" ", Array_clone);
Console.WriteLine(str);