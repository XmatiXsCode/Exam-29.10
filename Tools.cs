/*
klasa: Tools
opis: biblioteka narzędziowa
metody:
    CheckVowels = zwraca liczbę samogłosek znajdujących się w parametrze. Metoda przyjmuje jeden parametr będący ciągniem znaków (string_of_characters);
    FixSentence = zwraca ciąg znaków, zmieniony według podanych instrukcji. Metoda przyjmuje jeden parametr będący ciągniem znaków (sentence);
autor: 06xxxxxxx70
*/
class Tools
{
    public static int CheckVowels(string string_of_characters)
    {
        int how_many_vowels = 0;
        string vowels = "aąeęiouóyAĄEĘIOUÓY";
        foreach (char character in string_of_characters)
        {
            if (vowels.Contains(character))
            {
                how_many_vowels++;
            }
        }
        return how_many_vowels;
    }
    public static string FixSentence(string sentence)
    {
        int characters_in_sentence = sentence.Count()-1;
        for (int i = 0; i < characters_in_sentence; i++)
        {
            if (sentence[i] == sentence[i+1])
            {
                sentence = sentence.Remove(i+1, 1);
                i--;
                characters_in_sentence--;
            }
        }
        return sentence;
    }
}