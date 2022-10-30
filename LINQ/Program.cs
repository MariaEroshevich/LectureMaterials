using Microsoft.VisualBasic;

var names = new List<string>();

var queryExtension = names.Where(n => n.Contains('f')).Select(n => n.ToUpper()).OrderBy(n => n.Length);
var queryQuery = from n in names
                 where n.Contains('f')
                 orderby n.Length
                 select n.ToUpper();

var objects = new List<object> { "sdfsf", 32, 85.4 };
var query = objects.OfType<string>().ToList();
Console.ReadLine();
