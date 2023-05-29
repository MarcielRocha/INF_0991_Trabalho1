// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Mundo");
// Alteração realizada por Ana Beatriz
Console.WriteLine(new string('*', 10));    // **********

char[] ca = "Hello".ToCharArray();
string s = new string(ca);                 // Reconstrução de string a partir de vetor de chars
Console.WriteLine(s);                      // "Hello"

