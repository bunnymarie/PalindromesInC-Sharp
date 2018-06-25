using System;

class Palindrome
{
  public string Word { get; set; }

  public Palindrome(string input)
  {
    Word = input;
  }

  public bool IsPalindrome()
  {

    char[] originalPalindrome = Word.ToCharArray();
    char[] reversedPalindrome = Word.ToCharArray();
    Array.Reverse(reversedPalindrome);

    string S1 = new string(originalPalindrome);
    string S2 = new string(reversedPalindrome);
    return (S1 == S2);

    // for (int i = 0; i < originalPalindrome.Length; i++)
    // {
    //   if(originalPalindrome[i] == reversedPalindrome[i])
    //   {
    //     continue;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }
    // return true;
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word: ");
    string text = Console.ReadLine();

    Palindrome pal = new Palindrome(text);
    bool answer = pal.IsPalindrome();

    Console.WriteLine("The word is a Palindrome: " + answer);
  }
}
