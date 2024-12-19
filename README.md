# CompanyCoreLib

CompanyCoreLib is a .NET library that provides essential utilities for company data analytics. This library is designed for modular integration into various projects.

## Features
- **Analytics**: Analyze and predict the most popular months based on a list of purchase dates.

## Installation
1. Clone this repository.
2. Build the project in Visual Studio or any compatible IDE to generate the `CompanyCoreLib.dll` file.

## Usage
To use the `CompanyCoreLib` in your project:

1. Add a reference to the `CompanyCoreLib.dll` file.
2. Use the `Analytics` class as follows:

### Example Code
```csharp
using System;
using System.Collections.Generic;
using CompanyCoreLib;

class Program
{
    static void Main(string[] args)
    {
        var analytics = new Analytics();
        var purchaseDates = new List<DateTime>
        {
            new DateTime(2023, 12, 15),
            new DateTime(2023, 12, 10),
            new DateTime(2023, 11, 5),
            new DateTime(2023, 11, 20),
            new DateTime(2023, 12, 25),
        };

        var popularMonths = analytics.PopularMonths(purchaseDates);

        Console.WriteLine("Most popular months:");
        foreach (var date in popularMonths)
        {
            Console.WriteLine(date.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
```

### Output
If the purchase dates are:
- 2023-12-15
- 2023-12-10
- 2023-11-05
- 2023-11-20
- 2023-12-25

The output will be:
```
Most popular months:
2023-12-01 00:00
2023-11-01 00:00
```

## License
This project is licensed under the MIT License.
