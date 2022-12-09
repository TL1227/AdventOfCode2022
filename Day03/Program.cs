//Main
string[] input = File.ReadAllLines(@"C:\Users\lavelle.t\Documents\TomProjects\VS Code Projects\AdventOfCode2022\Day03\input.txt");

Console.WriteLine($"The answer to part 01 is {Part01(input)}");
Console.WriteLine($"The answer to part 02 is {Part02(input)}");

//Methods and Classes
int Part01(string[] input)
{
    List<char> duplicateItems = new List<char>();
    foreach (var row in input)
    {
        string[] compartments = SplitItemsIntoCompartments(row);
        char duplicateItem = FindDuplicateItemInBothCompartments(compartments);
        duplicateItems.Add(duplicateItem);
    }

    int result = GetPriorityTotalFromDuplicateItems(duplicateItems);

    return result;
}

int Part02(string[] input)
{
    var elfGroups = GetElfGroups(input);

    List<char> duplicateItems = new List<char>();
    foreach (var group in elfGroups)
    {
        var duplicateItem = FindDuplicateItemInElfGroup(group);
        duplicateItems.Add(duplicateItem);
    }

    int result = GetPriorityTotalFromDuplicateItems(duplicateItems);  

    return result;
}

string[] SplitItemsIntoCompartments(string items)
{
    int itemLength = items.Length;
    int compartmentLength = itemLength / 2;
    string firstCompartment = (items.Substring(0, compartmentLength));
    string secondCompartment = (items.Substring(compartmentLength, compartmentLength));

    string[] compartments = {firstCompartment, secondCompartment};
    return compartments;
}

char FindDuplicateItemInBothCompartments(string[] compartments)
{    
    var comp1Items = compartments[0].ToCharArray();
    var comp2Items = compartments[1].ToCharArray();
    
    foreach (var item1 in comp1Items)
    {
        foreach (var item2 in comp2Items)
        {
            if (item1 == item2)
            {
                return item1;
            }
        }  
    }

    return '0';
}

char FindDuplicateItemInElfGroup(ElfGroup elfGroup)
{    
    var elf1Items = elfGroup.Elf1.ToCharArray();
    var elf2Items = elfGroup.Elf2.ToCharArray();
    var elf3Items = elfGroup.Elf3.ToCharArray();
    
    foreach (var item1 in elf1Items)
    {
        foreach (var item2 in elf2Items)
        {
            if (item1 == item2)
            {
                foreach (var item3 in elf3Items)
                {
                    if (item1 == item3)
                    {
                        return item1;
                    }
                }
            }
        }  
    }

    return '0';
}

List<ElfGroup> GetElfGroups(string[] input)
{
    List<ElfGroup> elfGroups = new List<ElfGroup>();

    for (int i = 0; i < input.Length; i+=3)
    {
        ElfGroup elfGroup = new ElfGroup()
        {
            Elf1 = input[i],
            Elf2 = input[i + 1],
            Elf3 = input[i + 2]
        };
        elfGroups.Add(elfGroup);
    }

    return elfGroups;
}

int GetPriorityTotalFromDuplicateItems(List<char> duplicateItems)
{
    int result = 0;
    foreach (var duplicateItem in duplicateItems)
    {
        int priority = Priorities.dictionary[duplicateItem];
        result += priority;
    }

    return result;
}

class ElfGroup
{
    public string Elf1 { get; set; }
    public string Elf2 { get; set; }
    public string Elf3 { get; set; }
}


class Priorities
{
    public static Dictionary<char, int> dictionary = new Dictionary<char, int>()
    {
        {'a', 1},
        {'b', 2},
        {'c', 3},
        {'d', 4},
        {'e', 5},
        {'f', 6},
        {'g', 7},
        {'h', 8},
        {'i', 9},
        {'j', 10},
        {'k', 11},
        {'l', 12},
        {'m', 13},
        {'n', 14},
        {'o', 15},
        {'p', 16},
        {'q', 17},
        {'r', 18},
        {'s', 19},
        {'t', 20},
        {'u', 21},
        {'v', 22},
        {'w', 23},
        {'x', 24},
        {'y', 25},
        {'z', 26},
        {'A', 27},
        {'B', 28},
        {'C', 29},
        {'D', 30},
        {'E', 31},
        {'F', 32},
        {'G', 33},
        {'H', 34},
        {'I', 35},
        {'J', 36},
        {'K', 37},
        {'L', 38},
        {'M', 39},
        {'N', 40},
        {'O', 41},
        {'P', 42},
        {'Q', 43},
        {'R', 44},
        {'S', 45},
        {'T', 46},
        {'U', 47},
        {'V', 48},
        {'W', 49},
        {'X', 50},
        {'Y', 51},
        {'Z', 52}
    };
}
