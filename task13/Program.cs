Console.Clear();

    int number = 12;
    string numberText = Convert.ToString(number);
        if (numberText.Length > 2)
        {
        Console.WriteLine("third number is " + numberText[2]);
        }
        else 
        {
            Console.WriteLine("there is no third number");
        }