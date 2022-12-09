using System.Diagnostics;

string[] input = File.ReadAllLines(@"Input File Path");

Console.WriteLine($"Part 1 answer is: {Part01Answer(input)}");
Console.WriteLine($"Part 2 answer is: {Part02Answer(input)}");

int Part01Answer(string[] input)
{
    int score = 0;

    foreach (var row in input)
    {
        if (row.Contains('A')) //rock
        {
            if (row.Contains('X')) //R
            {
                score = score + 1;
                //draw
                score = score + 3;
            }
            else if (row.Contains('Y')) //P
            {
                score = score + 2;
                //win
                score = score + 6;
            }
            else if (row.Contains('Z')) //S
            {
                score = score + 3;
                //loss
            }
        }
        else if (row.Contains('B')) //paper
        {
            if (row.Contains('X')) //R
            {
                score = score + 1;
                //loss
            }
            else if (row.Contains('Y')) //P
            {
                score = score + 2;
                //draw
                score = score + 3;
            }
            else if (row.Contains('Z')) //S
            {
                score = score + 3;
                //win
                score = score + 6;
            }
        }
        else if (row.Contains('C')) //scissors
        {
            if (row.Contains('X')) //R
            {
                score = score + 1;
                //win
                score = score + 6;
            }
            else if (row.Contains('Y')) //P
            {
                score = score + 2;
                //loss
            }
            else if (row.Contains('Z')) //S
            {
                score = score + 3;
                //draw
                score = score + 3;
            }
        }
    }

    return score;
}

int Part02Answer(string[] input)
{
    int score = 0;

    foreach (var row in input)
    {
        if (row.Contains('A')) //rock
        {
            if (row.Contains('X')) //L
            {
                //S
                score = score + 3;
            }
            else if (row.Contains('Y')) //D
            {
                score = score + 3;
                //R
                score = score + 1;
            }
            else if (row.Contains('Z')) //W
            {
                score = score + 6;
                //P
                score = score + 2;
            }
        }
        else if (row.Contains('B')) //paper
        {
            if (row.Contains('X')) //L
            {
                //R
                score = score + 1;
            }
            else if (row.Contains('Y')) //D
            {
                score = score + 3;
                //P
                score = score + 2;
            }
            else if (row.Contains('Z')) //W
            {
                score = score + 6;
                //S
                score = score + 3;
            }
        }
        else if (row.Contains('C')) //scissors
        {
            if (row.Contains('X')) //L
            {
                //P
                score = score + 2;
            }
            else if (row.Contains('Y')) //D
            {
                score = score + 3;
                //S
                score = score + 3;
            }
            else if (row.Contains('Z')) //W
            {
                score = score + 6;
                //R
                score = score + 1;
            }
        }
    }

    return score;
}
