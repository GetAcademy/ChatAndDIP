using var reader = new StreamReader("file.txt");

var matchingLineCount = 0;
var totalLineCount = 0;
var line = reader.ReadLine();
while (line != null)
{
    if (line.Contains("e"))
    {
        matchingLineCount++;
    }

    totalLineCount++;
    line = reader.ReadLine();
}

Console.WriteLine($"{matchingLineCount} av {totalLineCount} inneholder e");
