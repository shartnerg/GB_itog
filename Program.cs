Console.Clear();
Console.Write("Skolko strok vy hotite vvesti?(vvedite razmer massiva): ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Vvedite {i + 1}-uy stroku: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine($"Vvedenny massiv strok: [{string.Join(", ", array)}]");

int count = 0;
foreach (string str in array)
{
    if (str.Length <= 3)
        count++;
}
string[] shortarray = new string[count];
int index = 0;
foreach (string str in array)
{
    if (str.Length <= 3)
    {
        shortarray[index] = str;
        index++;
    }
}


Console.WriteLine($"Stroki, menshe ili ravnye 3 simvolam: [{string.Join(", ", shortarray)}]");