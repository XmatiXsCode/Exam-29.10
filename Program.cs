//Console.WriteLine("Program liczący samogłoski.");
//Console.Write("Podaj ciąg znaków: ");
//string string_of_characters = Console.ReadLine();
//Console.WriteLine($"Liczba samogłosek w ciągu znaków: {Tools.CheckVowels(string_of_characters)}.");
Console.WriteLine("Program naprawiający zdanie.");
Console.Write("Podaj ciąg znaków: ");
string sentence = Console.ReadLine();
Console.WriteLine($"Naprawione zdanie: {Tools.FixSentence(sentence)}.");