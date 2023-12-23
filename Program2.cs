string orig = "OMG, I Never Use My Shift KeyButton!";
        string low = LowerCase(orig);
        Console.WriteLine(low);
        Console.ReadLine();
 string LowerCase(string orig)
    {
        string result = "";
        foreach (char c in orig)
        {
            if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }