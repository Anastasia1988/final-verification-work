string[] NewMassiv(string[] array, int count )
{    
    string[] newMass = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newMass[newMass.Length - count] = array[i];
            count--;
        }
    }
    return newMass;    
}
int CountString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
if (array[i].Length <= 3) count++;
    }
    return count;
}
void PrintNewMassiv(string[] array)
{    
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }    
    Console.Write("]");
    Console.WriteLine();
}
string[] massiv1 = { "hello", "2", "world", ":-)" };
int myCount1 = CountString(massiv1);
string[] myMass1= NewMassiv(massiv1,myCount1);
PrintNewMassiv(myMass1);
string[] massiv2 = { "1234", "1567", "-2", "computer science" };
int myCount2 = CountString(massiv2);
string[] myMass2= NewMassiv(massiv2,myCount2);
PrintNewMassiv(myMass2);
string[] massiv3 = { "Russia", "Denmark", "Kazan" };
int myCount3 = CountString(massiv3);
string[] myMass3= NewMassiv(massiv3,myCount3);
PrintNewMassiv(myMass3);

