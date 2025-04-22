using System.Text;

namespace README_Generator.Generate;

public class Generator
{
  private static string fileName = "README.md";

  public static void GenerateREADME(Inputs inputs)
  {
    StringBuilder readmeContent = new StringBuilder();

    // Title
    readmeContent.AppendLine($"# {inputs.ProjectName}");
    readmeContent.AppendLine();

    // Description
    readmeContent.AppendLine($"## Description");
    readmeContent.AppendLine(inputs.Description);
    readmeContent.AppendLine();

    // Table of Contents
    readmeContent.AppendLine($"## Table of Contents");
    readmeContent.AppendLine("- [Installation](#installation)");
    readmeContent.AppendLine("- [Usage](#usage)");
    readmeContent.AppendLine("- [Contributing](#contributing)");
    readmeContent.AppendLine("- [License](#license)");
    readmeContent.AppendLine("- [Tests](#tests)");
    readmeContent.AppendLine("- [Questions](#questions)");
    readmeContent.AppendLine();

    // Installation
    readmeContent.AppendLine($"## Installation");
    readmeContent.AppendLine(inputs.Install);
    readmeContent.AppendLine();

    // Usage
    readmeContent.AppendLine($"## Usage");
    readmeContent.AppendLine("Add usage instructions here.");
    readmeContent.AppendLine();

    // Contributing
    readmeContent.AppendLine($"## Contributing");
    readmeContent.AppendLine(inputs.Contribute);
    readmeContent.AppendLine();

    // License
    readmeContent.AppendLine($"## License");
    string license = GetLicense(inputs);
    readmeContent.AppendLine(license);

    // Tests
    readmeContent.AppendLine($"## Tests");
    readmeContent.AppendLine(inputs.Test);
    readmeContent.AppendLine();

    // Questions
    readmeContent.AppendLine($"## Questions");
    readmeContent.AppendLine($"* GitHub: [@{inputs.GithubUser}](https://www.github.com/{inputs.GithubUser})");
    readmeContent.AppendLine($"* Email: {inputs.Email}");
    readmeContent.AppendLine();

    // Write to file
    File.WriteAllText(fileName, readmeContent.ToString());
  }

  internal static string GetLicense(Inputs inputs)
  {
    return inputs.License switch
    {
      "1" => LicenseGenerator.GenerateMITLicense(inputs.GithubUser),
      "2" => LicenseGenerator.GenerateApacheLicense(inputs.GithubUser),
      "3" => LicenseGenerator.GenerateGPLv3License(inputs.GithubUser),
      "4" => LicenseGenerator.GenerateGPLv2License(inputs.GithubUser),
      "5" => LicenseGenerator.GenerateLGPLv3License(inputs.GithubUser),
      "6" => LicenseGenerator.GenerateAGPLv3License(inputs.GithubUser),
      "7" => LicenseGenerator.GenerateMPL2License(inputs.GithubUser),
      "8" => LicenseGenerator.GenerateEPL2License(inputs.GithubUser),
      "9" => LicenseGenerator.GenerateCC0License(inputs.GithubUser),
      "10" => LicenseGenerator.GenerateWTFPLLicense(inputs.GithubUser),
      "11" => LicenseGenerator.GenerateUnlicenseLicense(inputs.GithubUser),
      "12" => LicenseGenerator.GenerateOtherLicense(inputs.GithubUser),
      _ => "No license selected."
    };
  }
}