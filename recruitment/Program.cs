List<string> names = [
    "Tyler, The Creator",
    "Kanye West",
    "Kendrick Lamar",
    "Drake",
    "Travis Scott",
    "Playboi Carti",
    "Earl Sweatshirt",
    "Gunna",
    "Domo Genesis",
    "Frank Ocean",
    "A$AP Rocky",
    "Lil Tecca",
    "Freddie Gibbs",
    "Westside Gunn",
    "Joey Bada$$",
    "Future",
    "Ken Carson"
    ];
List<string> current = [];

while (current.Count < 5)
{
    Console.WriteLine("-- Names --");
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"[{i}] {names[i]}");
    }
    Console.WriteLine("\n-- Current members --");
    for (int i = 0; i < current.Count; i++)
    {
        Console.WriteLine($"{current[i]}");
    }

    Console.WriteLine("\nChoose a member:");
    int mNum = 0;
    bool couldConvert = false;
    while (couldConvert == false || mNum < 0 || mNum >= names.Count)
    {
        string nText = Console.ReadLine();
        couldConvert = int.TryParse(nText, out mNum);

        if (couldConvert == false)
        {
            Console.WriteLine("That is not a number!");
        }
        else if (mNum < 0 || mNum >= names.Count)
        {
            Console.WriteLine("That is not a valid index!");
        }
    }

    string member = names[mNum];
    current.Add(member);
    names.RemoveAt(mNum);
}

Console.WriteLine($"You chose a total of {current.Count} members.");

Console.WriteLine("Press ENTER to exit");
Console.ReadLine();