using CountLines;


var source = new FileLineSource("file.txt");
var lineCountService = new LineCountService2(source);
var stats = lineCountService.GetCounts("e");
stats.Show();

//using var reader = new StreamReader("file.txt");
//var searchText = "e";
//var matchingLineCount = 0;
//var totalLineCount = 0;
//var line = reader.ReadLine();
//while (line != null)
//{
//    if (line.Contains(searchText))
//    {
//        matchingLineCount++;
//    }

//    totalLineCount++;
//    line = reader.ReadLine();
//}

//Console.WriteLine($"{matchingLineCount} av {totalLineCount} linjer inneholder {searchText}");
