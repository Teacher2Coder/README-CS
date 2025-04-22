using README_Generator.Questions;
using README_Generator.Generate;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-------------------------------");
Console.WriteLine("|      README Generator!      |");
Console.WriteLine("-------------------------------");
Console.ResetColor();

// Create a new Input instance
Inputs inputs = new Inputs();

// Ask user for inputs
inputs.ProjectName = Questions.AskProjectName();
inputs.GithubUser = Questions.AskGithubUser();
inputs.Email = Questions.AskEmail();
inputs.Description = Questions.AskDescription();
inputs.Install = Questions.AskInstall();
inputs.License = Questions.AskLicense();
inputs.Contribute = Questions.AskContribute();

// Inform the user that the README.md is being generated
Console.WriteLine("Generating README.md...");

// Generate README.md with the provided inputs
Generator.GenerateREADME(inputs);

// Inform the user that the README.md has been generated
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("README.md generated successfully!");

// Inform the user that the application is closing
Console.WriteLine("Closing application...");
Console.ResetColor();