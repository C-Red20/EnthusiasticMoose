﻿using System;

class Program
{
    static void Main()
    {
        PrintWelcomeMessage();

        // Let the moose speak!
        MooseSays("H I, I'M  E N T H U S I A S T I C !");
        MooseSays("I really am enthusiastic");

        // Ask some questions
        CanadaQuestion();
        EnthusiasticQuestion();
        LoveCSharpQuestion();
        SecretQuestion();
    }

    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
    }

    static void MooseSays(string message)
    {
        Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }

    static bool MooseAsks(string question)
    {
        Console.Write($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();

        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        return (answer == "y");
    }

    static void CanadaQuestion()
    {
        AskYesNoQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    }

    static void EnthusiasticQuestion()
    {
        AskYesNoQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
    }

    static void LoveCSharpQuestion()
    {
        AskYesNoQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    }

    static void SecretQuestion()
    {
        AskYesNoQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
    }

    static void AskYesNoQuestion(string question, string yesResponse, string noResponse)
    {
        bool answer = MooseAsks(question);
        if (answer)
        {
            MooseSays(yesResponse);
        }
        else
        {
            MooseSays(noResponse);
        }
    }
}