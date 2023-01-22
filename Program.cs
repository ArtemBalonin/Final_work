string[] array1 = new string[7] {"hello","2", "world", ":-)", "123", "ABC", "321"};
string[] array2 = new string[array1.Length];
void SecondArrayWithif(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count ++;
        }
    }
}

void PrintArray (string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length -1) Console.Write(",");
    }
    Console.WriteLine("]");

}

SecondArrayWithif(array1, array2);
PrintArray(array2);



