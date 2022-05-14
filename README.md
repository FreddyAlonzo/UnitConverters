**UnitConverters**

**Running the program**

This program can be run in Visual Studio 2022 or Visual Studio Code.

To run the program in Visual Studio 2022:
1. Clone the repository and open the solution (.sln) file.
2. Run The "UnitConvertersAPI" project. 
3. During the first run Visual Studio will ask for permissions to trust and install the SSL certificate.
4. A new browser tab will open and the user will be able to interact with it.

Note: Visual Studio must have the ASP.NET and web development component.

To run the program in Visual Studio Code:
1. Clone the repository and open the folder in Visual Studio Code.
2. Trust and install the SSL certificate using the following command in the terminal. <br> <code>dotnet dev-certs https --trust</code>
3. Click Run and Debug.
4. When running the program for the first time a warning will show up asking to add missing assets, click "Yes".
5. Select the UnitConvertersAPI project.
6. Run the project.
7. A new browser tab will open and the user will be able to interact with it. 

Note: The following components must be installed in the machine:  
- <a href="https://dotnet.microsoft.com/en-us/download/visual-studio-sdks"> NET 6.0 SDK </a>
- <a href="https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp">C# Visual Studio Code extension</a>

**General notes**

Types of units that can be converted:
- Temperature (Celsius, Fahrenheit, and Kelvin).
- Length (Miles, and Kilometers).
- Weight (Pounds, and Kilograms).
- Height (Metric (meters and centimeters), and Imperial (feet and inches)) 

The "Height" tools are meant to be used as a tool to convert human heights. For other types of linear measurements use the "Length" tools. 
