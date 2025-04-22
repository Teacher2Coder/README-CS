using System;
using System.Formats.Asn1;
using README_Generator.Generate;


namespace README_Generator.Questions;

class Questions
{

  public static string AskProjectName()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What is the name of the project?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Project name cannot be empty.");
      Console.ResetColor();
      return AskProjectName();
    }
    return answer;
  }

  public static string AskGithubUser()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What is your Github username? ");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Github username cannot be empty.");
      Console.ResetColor();
      return AskGithubUser();
    }
    return answer;
  }

  public static string AskEmail()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What is your email?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Email cannot be empty.");
      Console.ResetColor();
      return AskEmail();
    }
    return answer;
  }

  public static string AskDescription()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Describe your project in a few sentences.");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Project description cannot be empty.");
      Console.ResetColor();
      return AskDescription();
    }
    return answer;
  }

  public static string AskInstall()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("How do you install the project?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Installation details cannot be empty.");
      Console.ResetColor();
      return AskInstall();
    }
    return answer;
  }

  public static string AskLicense()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What licence do you want for the project?");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("[ 1 ] MIT");
    Console.WriteLine("[ 2 ] Apache 2.0");
    Console.WriteLine("[ 3 ] GNU GPL v3");
    Console.WriteLine("[ 4 ] GNU GPL v2");
    Console.WriteLine("[ 5 ] GNU LGPL v3");
    Console.WriteLine("[ 6 ] GNU AGPL v3");
    Console.WriteLine("[ 7 ] Mozilla Public License 2.0");
    Console.WriteLine("[ 8 ] Eclipse Public License 2.0");
    Console.WriteLine("[ 9 ] Creative Commons Zero v1.0 Universal");
    Console.WriteLine("[ 10 ] WTFPL");
    Console.WriteLine("[ 11 ] No licence");
    Console.WriteLine("[ 12 ] Other");
    Console.ResetColor();
    
    while (true)
    {
      string answer = Console.ReadLine() ?? string.Empty;
      
      if (string.IsNullOrEmpty(answer))
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Licence type cannot be empty.");
        Console.ResetColor();
        continue;
      }
      
      if (answer == "1" || answer == "2" || answer == "3" || answer == "4" ||
          answer == "5" || answer == "6" || answer == "7" || answer == "8" ||
          answer == "9" || answer == "10" || answer == "11" || answer == "12")
      {
        return answer;
      }
      
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
      Console.ResetColor();
    }
  }

  public static string AskContribute()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("How can others contribute to the project?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Contribution section cannot be empty.");
      Console.ResetColor();
      return AskContribute();
    }
    return answer;
  }

  public static string AskTest()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("How do you test the project?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Test section cannot be empty.");
      Console.ResetColor();
      return AskTest();
    }
    return answer;
  }
}