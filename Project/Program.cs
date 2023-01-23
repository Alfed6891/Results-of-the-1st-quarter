Console.Write("Введите значения через запятую:");
string? mas = Console.ReadLine();
string [] newrray  =  mas.Split(',');

WriteArray(newrray);

string [] selectArray = new string [CountingSelectElements(newrray,3)];

WriteSelectElements (newrray,selectArray,3);

WriteArray (selectArray);

int CountingSelectElements (string [] array, int condition)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= condition)
        {
            count++;
        }

    } 
    return count;
}

void WriteSelectElements (string [] array, string [] resultArray, int condition)
{
    int count = 0;
     for(int i = 0; i < resultArray.Length; i++)
    {
        for (int j = count; j < array.Length; j++)
        {
            if (array[j].Length <= condition)
            {
                resultArray[i] = array[j];
                
               
            }
            count = j+1;
            break;
        }
    }
}

void WriteArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }

    Console.WriteLine();
}
