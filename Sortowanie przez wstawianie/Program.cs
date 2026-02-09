using Sortowanie_przez_wstawianie;

Random rand = new Random();

int[] Array = new int[rand.Next(5, 150)];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = rand.Next(0, 100);
}

int[] SortedArray = Sorter.Sort(Array);
Console.WriteLine(string.Join(", ", SortedArray));
