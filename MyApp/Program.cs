// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var path = @"f:\numbers.txt";
string[] textNumbers = ReadNumbersFromTextFile(path);

List<int> numbers = ParseNumbers(textNumbers);

int min, max;

GetMinMax(numbers, out min, out max);

var mid = (min + max) / 2;

Console.WriteLine(mid);

Console.WriteLine("Done!");

static string[] ReadNumbersFromTextFile(string filePath)
{
    try
    {
        var text = File.ReadAllText(filePath);
        var textNumbers = text.Split(',');
        return textNumbers;
    }
    catch (FileNotFoundException ex)
    {

        Console.WriteLine("File not found: {0}", ex.FileName);
        return Array.Empty<string>();
    }

}

static List<int> ParseNumbers(string[] textNumbers)
{
    var numbers = new List<int>();
    foreach (var number in textNumbers)
    {
        numbers.Add(int.Parse(number));
    }

    return numbers;
}

static void GetMinMax(List<int> numbers, out int min, out int max)
{
    var orderedNumbers = numbers.OrderBy(x => x).ToList();

    min = orderedNumbers.First();
    max = orderedNumbers.Last();
}