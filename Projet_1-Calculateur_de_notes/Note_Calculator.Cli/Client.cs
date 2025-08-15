
using   Note_Calculator.Domain;

using   System;
using   System.Linq;
using   System.Runtime;
using   System.Globalization;
using   System.Diagnostics.Tracing;


namespace Note_Calculator.CLi;

internal class Client
{
    ClientMsg clientMsg = new();

    const String prompt = "➤ ";
    const String EXIT = "exit";
    bool clientLoop = true;

    public void Run()
    {
        clientMsg.WelcomeMsg();
        while (clientLoop)
        {
            Console.Write(prompt);
            string? userInput = Console.ReadLine();

            if (!checkExit(userInput))
                return;

            if (checkInput(userInput))
                clientLoop = Treatement(userInput);
        }

    }

    private bool Treatement(string userInput)
    {
        try
        {
            double[] notes = userInput.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                      .Select(n => double.Parse(n.Trim(), CultureInfo.InvariantCulture))
                                      .ToArray();

            var student = new Student();
            student.AddNotes(notes);

            bool isValid = student.IsPassingYear();
            string mention = student.GetMention();

            Console.WriteLine($"{prompt}------------   Résultat    ---------");
            Console.WriteLine($"{prompt}Moyenne suffisante : {(isValid ? "✅ Oui" : "❌ Non")}");
            Console.WriteLine($"{prompt}Mention : {mention}");

            return true;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"{prompt} Erreur : {ex.Message}");
        }

        return false;
    }

    private bool checkExit(string userInput)
    {
        if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            clientMsg.ExitMsg();
            return false;
        }

        return true;
    }

    private bool checkInput(string userInput)
    {
        if (string.IsNullOrEmpty(userInput))
            return false;

        foreach (var c in userInput)
        {
            if (!char.IsDigit(c) && c != ',' && c != '.' && !char.IsWhiteSpace(c))
            {
                clientMsg.Exception_Invalid_Input();
                return false;
            }
        }

        return true;
    }
}

internal class Program
{
    static int Main()
    {
        Client client = new();

        client.Run();

        return 0;
    }
}