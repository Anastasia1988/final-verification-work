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
string[] massiv1 = { "hello", "2", "world", ":-)" };
int myCount1 = CountString(massiv1);
string[] myMass1= NewMassiv(massiv1,myCount1);
PrintNewMassiv(myMass1);
