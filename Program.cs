string[] array = { "1234", "156", "-2", "computer science", "08", "a", "test" };

string[] newarray = new string[array.Length];

int index = 0;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newarray[index] = array[i];
        index++;
        count++;
    }

}

Array.Resize(ref newarray, count);

for (int i = 0; i < newarray.Length; i++)
{
    Console.WriteLine(newarray[i]);
}
