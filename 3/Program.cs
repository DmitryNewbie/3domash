Console.Write("Введите число ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube (int[] cube)
{
    int lengt = cube.Length;
    int counter = 0;
    
    while (counter < lengt)
    {
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void Printarry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(coll[index]+ " ");
        index++;
    }
}

int[] arry = new int[cube+1];
Cube(arry);
Printarry(arry);