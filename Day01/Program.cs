
string[] input = File.ReadAllLines(@"InputPath");

int partOneAnswer = Part01(input);
Console.WriteLine($"The answer to part one is: {partOneAnswer}");

int partTwoAnswer = Part02(input);
Console.WriteLine($"The answer to part one is: {partTwoAnswer}");

int Part01(string[] input)
{
    //add up the calories each elf has and store their totals into a List<int>
    List<int> elvesCalorieTotals = new();
    int currentCalorieCount = 0;
    foreach (var foodItem in input)
    {
        if (foodItem != "")
        {
            int calories = Int32.Parse(foodItem);
            currentCalorieCount = currentCalorieCount + calories;
        }
        else
        {
            elvesCalorieTotals.Add(currentCalorieCount);
            currentCalorieCount = 0;
        }
    }

    return elvesCalorieTotals.Max();
}

int Part02(string[] input)
{
    //add up the calories each elf has and store their totals into a List<int>
    List<int> elvesCalorieTotals = new();
    int currentCalorieCount = 0;
    foreach (var foodItem in input)
    {
        if (foodItem != "")
        {
            int calories = Int32.Parse(foodItem);
            currentCalorieCount = currentCalorieCount + calories;
        }
        else
        {
            elvesCalorieTotals.Add(currentCalorieCount);
            currentCalorieCount = 0;
        }
    }

    //return the total of highest three numbers
    var orderedList = elvesCalorieTotals.Order().ToList();
    int numberOfElves = orderedList.Count();

    int elf1 = orderedList[numberOfElves - 1];
    int elf2 = orderedList[numberOfElves - 2];
    int elf3 = orderedList[numberOfElves - 3];

    int highest3ElvesTotal = elf1 + elf2 + elf3;

    return highest3ElvesTotal;
}

