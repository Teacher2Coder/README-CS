using System.Text;

namespace README_Generator.Generate;

public static class LicenseGenerator
{
    public static string GenerateMITLicense(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:");
        licenseContent.AppendLine();
        licenseContent.AppendLine("The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.");
        licenseContent.AppendLine();
        licenseContent.AppendLine("THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.");
        return licenseContent.ToString();
    }

    public static string GenerateApacheLicense(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
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
        return licenseContent.ToString();
    }

    public static string GenerateGPLv3License(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: GPL](https://img.shields.io/badge/License-GPL-blue.svg)](https://opensource.org/licenses/GPL-3.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
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
        return licenseContent.ToString();
    }

    public static string GenerateGPLv2License(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: GPL](https://img.shields.io/badge/License-GPL-blue.svg)](https://opensource.org/licenses/GPL-2.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("This program is free software: you can redistribute it and/or modify");
        licenseContent.AppendLine("it under the terms of the GNU General Public License as published by");
        licenseContent.AppendLine("the Free Software Foundation, either version 2 of the License, or");
        licenseContent.AppendLine("(at your option) any later version.");
        licenseContent.AppendLine();
        licenseContent.AppendLine("This program is distributed in the hope that it will be useful,");
        licenseContent.AppendLine("but WITHOUT ANY WARRANTY; without even the implied warranty of");
        licenseContent.AppendLine("MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the");
        licenseContent.AppendLine("GNU General Public License for more details.");
        licenseContent.AppendLine();
        licenseContent.AppendLine("You should have received a copy of the GNU General Public License");
        licenseContent.AppendLine("along with this program. If not, see <https://www.gnu.org/licenses/>.");
        return licenseContent.ToString();
    }

    public static string GenerateLGPLv3License(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: LGPL](https://img.shields.io/badge/License-LGPL-blue.svg)](https://www.gnu.org/licenses/lgpl-3.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Lesser General Public License v3.0");
        return licenseContent.ToString();
    }

    public static string GenerateAGPLv3License(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: AGPL](https://img.shields.io/badge/License-AGPL-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("GNU Affero General Public License v3.0");
        return licenseContent.ToString();
    }

    public static string GenerateMPL2License(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: MPL](https://img.shields.io/badge/License-MPL-blue.svg)](https://opensource.org/licenses/MPL-2.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Mozilla Public License 2.0");
        return licenseContent.ToString();
    }

    public static string GenerateEPL2License(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: EPL](https://img.shields.io/badge/License-EPL-blue.svg)](https://opensource.org/licenses/EPL-2.0)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Eclipse Public License - v 2.0");
        return licenseContent.ToString();
    }

    public static string GenerateCC0License(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: CC0](https://img.shields.io/badge/License-CC0-blue.svg)](https://creativecommons.org/publicdomain/zero/1.0/)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Creative Commons Zero v1.0 Universal");
        return licenseContent.ToString();
    }

    public static string GenerateWTFPLLicense(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: WTFPL](https://img.shields.io/badge/License-WTFPL-blue.svg)](http://www.wtfpl.net/about/)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Do What The Fuck You Want To Public License");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Version 2, December 2004");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Copyright (C) 2004 Sam Hocevar <sam@hocevar.net>");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Everyone is permitted to copy and distribute verbatim or modified copies of this license document, and changing it is allowed as long as the name is changed.");
        return licenseContent.ToString();
    }

    public static string GenerateUnlicenseLicense(string githubUser)
    {
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine("[![License: Unlicense](https://img.shields.io/badge/License-Unlicense-blue.svg)](https://unlicense.org/)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("This is free and unencumbered software released into the public domain.");
        return licenseContent.ToString();
    }

    public static string GenerateOtherLicense(string githubUser)
    {
        Console.WriteLine("Please enter the license name:");
        string licenseName = Console.ReadLine() ?? string.Empty;
        var licenseContent = new StringBuilder();
        licenseContent.AppendLine($"![License: {licenseName}](https://img.shields.io/badge/License-{licenseName}-blue.svg)");
        licenseContent.AppendLine();
        licenseContent.AppendLine($"Copyright (c) {DateTime.Now.Year} {githubUser}");
        licenseContent.AppendLine();
        licenseContent.AppendLine("Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:");
        licenseContent.AppendLine();
        licenseContent.AppendLine("The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.");
        return licenseContent.ToString();
    }
} 