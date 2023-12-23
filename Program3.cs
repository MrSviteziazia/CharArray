string input = "шалаш";
        bool Palindrome = IsPalindrome(input);
        if (Palindrome)
        {
            Console.WriteLine("это палиндром");
        }
        else
        {
            Console.WriteLine("это не палиндром");
        }
        Console.ReadLine();
        bool IsPalindrome(string text)
    {
        string Text = text.Replace(" ", "").ToLower();
        int length = Text.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (Text[i] != Text[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
