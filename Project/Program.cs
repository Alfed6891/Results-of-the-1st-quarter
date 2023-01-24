Console.Write("Введите значения через запятую, / или пробел:");
string? mas = Console.ReadLine();
string [] newArray  =  mas.Split(',','/',' ');

Console.Write("Введите максимальное количество символов в искомых значениях:");
int condition = Convert.ToInt32 (Console.ReadLine());

WriteArray(newArray);

string [] selectArray = new string [CountingSelectElements(newArray,condition)];

WriteSelectElements (newArray,selectArray,condition);

Console.Write ($"Следующие элементы значений имеют {condition} и меньше символов: ");
WriteArray (selectArray);

int CountingSelectElements (string [] array, int condition)
{
    int count = 0;
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
                count = j+1;
                break;
            }
            
            
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
