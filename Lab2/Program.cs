Console.WriteLine("Part1: Operator Practice");

int a = 10;
int b = 5;
int c = 15;

// Perform comparisons
bool aGreaterThanB = a > b;
bool aLessThanC = a < c;
bool aGreaterThanBoth = a > b & a > c;
bool aGreaterThanEither = a > b || a > c;

// Print results
Console.WriteLine("a > b: {aGreaterThanB}");
Console.WriteLine($"a < c: {aLessThanC}");
Console.WriteLine($"a > b & a > c: {aGreaterThanBoth}");
Console.WriteLine($"a > b || a > c: {aGreaterThanEither}");
Console.WriteLine();

// Part 2: Boolean Logic
Console.WriteLine("=== Part 2: Boolean Logic ===");
// Boolean variables
bool isRaining = true;
bool haveUmbrella = false;

// Conditional logic
if (isRaining & !haveUmbrella)
{
    Console.WriteLine("Take an umbrella!");
}
else
{
    Console.WriteLine("You're good to go!");
}

// Part 3: Movie Ticket Pricing
Console.WriteLine("=== Part 3: Conditional Logic – Movie Ticket Pricing ===");
// Get user input - age
Console.Write("Enter age: ");
if (!int.TryParse(Console.ReadLine(), out int age))

{
    Console.WriteLine("Invalid. Enter a number.");
    return; // if input is not valid
}
//  ticket price based on age
if (age < 5)
{
    Console.WriteLine("Ticket is free!");
}
else if (age <= 12)
{
    Console.WriteLine("Child ticket: $5");
}
else if (age <= 64)
{
    Console.WriteLine("Standard ticket: $10");
}
else
{
    Console.WriteLine("Senior ticket: $6");
}
Console.WriteLine();

// Part 4: switch statement
Console.WriteLine("=== Part 4: Using a switch Statement ===");
// day of week input with error handling
Console.Write("Enter a day of the week (1–7): ");
if (!int.TryParse(Console.ReadLine(), out int dayNumber))
{
    Console.WriteLine("Invalid number. Please enter 1-7.");
    return; 
}

// Switch statement
switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day!");
        break;

Console.WriteLine("Thank you! end of Lab 2 - Avi Zarbavel 7/14/2025")
}
