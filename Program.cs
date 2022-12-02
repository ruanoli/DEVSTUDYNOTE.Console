
string texto = "ASP.NET é um framework bastante poderoso .NET.";

string sub = texto.Substring(3,4);
bool end =texto.EndsWith("poderoso.");
bool contains = texto.Contains("framework");
bool comeca = texto.StartsWith("AST");
int index = texto.IndexOf(".NET");
int lastIndex = texto.LastIndexOf(".NET");

Console.WriteLine($@"Substring: {sub}
Final do texto?: {end}
Contém? {contains}
Começa com...? {comeca}
Primeiro valor da condição: {index}
Último valor da condição: {lastIndex}");

int[] grades = {1,2,3,4,5,6,7,8,9,10};
List<int> listaGrade = new List<int> {1,2,3,4,5,6,7,8,9,10,5,10};

var tArray = grades.ToList();
var tList = listaGrade.ToArray();

var single = grades.Single(x => x == 5);
var where = grades.Where(x => x > 8);
var first = grades.First(x => x == 10);
var any = grades.Any(x => x ==0);
var sum = grades.Sum();
var max = grades.Max();
var avg = grades.Average();
var count = grades.Count();
var order = grades.OrderBy(x => x);

Console.WriteLine($@"
single: {single}
first: {first}
any: {any}
sum: {sum}
max: {max}
avg: {avg}
count: {count}");
