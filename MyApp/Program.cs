// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var text = File.ReadAllText(@"f:\numbers.txt"); 
var textNumbers=text.Split(',');

var numbers=new List<int>();
foreach (var number in textNumbers)
{
    numbers.Add(int.Parse(number));
}

var orderedNumbers=numbers.OrderBy(x => x).ToList();

var min=orderedNumbers.First();
var max=orderedNumbers.Last();

var mid = (min + max) / 2;

Console.WriteLine(mid);

Console.WriteLine("Done!");



