string[] Animals = GetData();
string[] Part = Pagination(Animals, 5);
Part = Search(Animals, "ва");
Print(Part);

string[] GetData()
{
    string text = File.ReadAllText("D://Animals.txt");
    string[] animals = text.Split("\n");
    return animals;
}

void Print(string[] Data)
{
    foreach (string Animal in Data)
    {
        Console.WriteLine(Animal);
    }
}

string[] Pagination(string[] Data, int Count)
{
    string[] Animals = new string[Count];
    for (int i = 0; i < Count; i++)
    {
        Animals[i] = Data[i];
    }
    return Animals;
}

string[] Search(string[] Data, string Line)
{
    int num = GetCount(Data, Line);
    string[] Animals = new string[num];
    int j = 0;
    for (int i = 0; i < Data.Length; i++)    
    {
        if (Data[i].Contains(Line)) 
            Animals[j++] = Data[i];
    }
    return Animals;
}

int GetCount(string[] Data, string Line)
{
    int num = 0;
    foreach (string Animal in Data)
    {
        if (Animal.Contains(Line))
            num++;
    }
    return num;
}