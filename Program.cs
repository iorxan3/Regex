using System.Text.RegularExpressions;
string pattern = @"^\w[\w-]*@[\w]+(\.[\w]+)+";
Console.WriteLine(Regex.IsMatch("uiorxan@gmail.com",pattern));
Console.WriteLine(Regex.IsMatch("uiorxan@code.edu.az", pattern));
Console.WriteLine(Regex.IsMatch("ui-orxan@code.edu.az", pattern));
Console.WriteLine(Regex.IsMatch("_uiorxan@code.edu.az", pattern));