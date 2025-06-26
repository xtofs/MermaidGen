# MermaidGen

A .NET class library template with console application demo.

## Overview

This template creates a solution with two projects:
- **MermaidGen**: A class library containing reusable components
- **MermaidGen.Console**: A console application that demonstrates the class library functionality

## Features

- **Calculator**: Basic arithmetic operations (Add, Subtract, Multiply, Divide)
- **StringUtils**: String manipulation utilities (Reverse, CountWords, ToTitleCase)
- Clean architecture with separation of concerns
- Comprehensive XML documentation
- Console application for testing and demonstration

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022, Visual Studio Code, or any compatible IDE

### Building the Solution

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run the console application
dotnet run --project src/MermaidGen.Console
```

### Running Tests

```bash
# Run all tests (if test projects are added)
dotnet test
```

## Project Structure

```
MermaidGen/
├── src/
│   ├── MermaidGen/              # Class library project
│   │   ├── Calculator.cs        # Calculator utility class
│   │   ├── StringUtils.cs       # String manipulation utilities
│   │   └── MermaidGen.csproj    # Class library project file
│   └── MermaidGen.Console/      # Console application project
│       ├── Program.cs           # Console application entry point
│       └── MermaidGen.Console.csproj  # Console project file
├── MermaidGen.sln               # Solution file
├── .gitignore                   # Git ignore file
├── LICENSE                      # MIT License
└── README.md                    # This file
```

## Usage Examples

### Calculator

```csharp
using MermaidGen;

var calculator = new Calculator();
int sum = calculator.Add(10, 5);        // Returns 15
int difference = calculator.Subtract(10, 5);  // Returns 5
int product = calculator.Multiply(10, 5);     // Returns 50
double quotient = calculator.Divide(10, 5);   // Returns 2.0
```

### StringUtils

```csharp
using MermaidGen;

string reversed = StringUtils.Reverse("hello");           // Returns "olleh"
int wordCount = StringUtils.CountWords("hello world");    // Returns 2
string titleCase = StringUtils.ToTitleCase("hello world"); // Returns "Hello World"
```

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

If you encounter any issues or have questions, please open an issue on the repository.

---

*This project was created using the MermaidGen .NET template.*
