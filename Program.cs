Random random = new Random();

int points = 0;
int count = 0;

List<int> dadi = new List<int>();

while (count != 10)
{
    Console.WriteLine("Premi un tasto per lanciare i dadi.");
    Console.ReadLine();
    dadi.Add(random.Next(0, 6));
    count = count + 1;
    foreach (var i in dadi)
    {
        string.Join(", ", dadi);
        Console.Write("|" + i + "|");
    }

    if (dadi.Contains(5))
    {
        Console.WriteLine(" 5 è nella lista.");
        points = points + 1;
    }
    if (dadi.Contains(2))
    {
        Console.WriteLine(" 2 è nella lista.");
        points = points + 1;
    }
}

// test
