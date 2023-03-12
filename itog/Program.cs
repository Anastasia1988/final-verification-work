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
