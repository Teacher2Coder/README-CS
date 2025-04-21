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
    StringBuilder licenseContent = new StringBuilder();

    switch (inputs.License)
    {
      case "1":
        licenseContent.AppendLine("[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {inputs.GithubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:");
        licenseContent.AppendLine();
        licenseContent.AppendLine("The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.");
        licenseContent.AppendLine();
        licenseContent.AppendLine("THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.");
        break;
      case "2":
        licenseContent.AppendLine("[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {inputs.GithubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Licensed under the Apache License, Version 2.0 (the \"License\");");
        licenseContent.AppendLine("you may not use this file except in compliance with the License.");
        licenseContent.AppendLine("You may obtain a copy of the License at");
        licenseContent.AppendLine("http://www.apache.org/licenses/LICENSE-2.0");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Unless required by applicable law or agreed to in writing, software");
        licenseContent.AppendLine("distributed under the License is distributed on an \"AS IS\" BASIS,");
        licenseContent.AppendLine("WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.");
        licenseContent.AppendLine("See the License for the specific language governing permissions and");
        licenseContent.AppendLine("limitations under the License.");
        break;
      case "3":
        licenseContent.AppendLine("[![License: GPL](https://img.shields.io/badge/License-GPL-blue.svg)](https://opensource.org/licenses/GPL-3.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {inputs.GithubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("This program is free software: you can redistribute it and/or modify");
        licenseContent.AppendLine("it under the terms of the GNU General Public License as published by");
        licenseContent.AppendLine("the Free Software Foundation, either version 3 of the License, or");
        licenseContent.AppendLine("(at your option) any later version.");
        licenseContent.AppendLine();
        licenseContent.AppendLine("This program is distributed in the hope that it will be useful,");
        licenseContent.AppendLine("but WITHOUT ANY WARRANTY; without even the implied warranty of");
        licenseContent.AppendLine("MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the");
        licenseContent.AppendLine("GNU General Public License for more details.");
        licenseContent.AppendLine();
        licenseContent.AppendLine("You should have received a copy of the GNU General Public License");
        licenseContent.AppendLine("along with this program. If not, see <https://www.gnu.org/licenses/>.");
        break;
      case "4":
        licenseContent.AppendLine("[![License: MPL](https://img.shields.io/badge/License-MPL-blue.svg)](https://opensource.org/licenses/MPL-2.0)");
        break;
      case "5":
        licenseContent.AppendLine("[![License: CC](https://img.shields.io/badge/License-CC-blue.svg)](https://creativecommons.org/licenses/)");
        break;
      case "6":
        licenseContent.AppendLine("[![License: BSD](https://img.shields.io/badge/License-BSD_3--Clause-blue.svg)](https://opensource.org/licenses/BSD-3-Clause)");
        break;
      case "7":
        licenseContent.AppendLine("[![License: BSD](https://img.shields.io/badge/License-BSD_2--Clause-blue.svg)](https://opensource.org/licenses/BSD-2-Clause)");
        break;
      case "8":
        licenseContent.AppendLine("[![License: EPL](https://img.shields.io/badge/License-EPL-blue.svg)](https://opensource.org/licenses/EPL-2.0)");
        break;
      case "9":
        licenseContent.AppendLine("[![License: ISC](https://img.shields.io/badge/License-ISC-blue.svg)](https://opensource.org/licenses/ISC)");
        break;
      case "10":
        licenseContent.AppendLine("[![License: Zlib](https://img.shields.io/badge/License-Zlib-blue.svg)](https://opensource.org/licenses/Zlib)");
        break;
      case "11":
        licenseContent.AppendLine("[![License: Unlicense](https://img.shields.io/badge/License-Unlicense-blue.svg)](https://unlicense.org/)");
        break;
      case "12":
        licenseContent.AppendLine("[![License: WTFPL](https://img.shields.io/badge/License-WTFPL-blue.svg)](http://www.wtfpl.net/about/)");
        break;
      default:
        licenseContent.AppendLine("No license selected.");
        break;
    }

    return licenseContent.ToString();
  }
}
