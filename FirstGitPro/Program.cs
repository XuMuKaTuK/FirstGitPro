using System;
using System.Collections.Generic;

Console.Write("Введите число: ");
var a = Int32.Parse(Console.ReadLine());
int[] first = new int[a];
List<string> oddnumbers = new List<string>();
List<string> evennumbers = new List<string>();
List<string> subs = new List<string>();
string alphabet = ( @"abcdefghijklmnopqrstuvwxyz");



for (int i = 0; i < a; i++)
{
    first[i] = new Random().Next(1,26);
    if (first[i] % 2 == 0)
        evennumbers.Add(alphabet.Substring(first[i],1));
    else
        oddnumbers.Add(alphabet.Substring(first[i],1));
}
Console.Write($"Четные: ");
for (int j = 0; j < oddnumbers.Count; j++)
    Console.Write($"{oddnumbers[j]} ");
Console.Write($"\nНечетные: ");
for (int j = 0; j < evennumbers.Count; j++)
    Console.Write($"{evennumbers[j]} ");
var resault = string.Empty;
foreach (var sub in subs)
{
    if (sub.ToString().ToLower() == "a" || sub.ToString().ToLower() == "e" || sub.ToString().ToLower() == "i" ||
        sub.ToString().ToLower() == "d" || sub.ToString().ToLower() == "h" || sub.ToString().ToLower() == "j" )
    {
        resault = $"{subs.ToString().ToUpper()}";
    }
    
}
    Console.WriteLine($"{resault}");


//Console.WriteLine("Кол-во больших четных:" + .Length);
//Console.WriteLine("Кол-во больших нечетных:" + .Length);

