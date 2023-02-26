/* BREIF:
 * 
 * Capture a user's age from the Console and then identify how old they will be
 * in 25 years, as well as how old they were 25 years ago. Print that 
 * information to the Console in natural language.
 * 
 */

Console.Write("How old are you?: ");
string? ageText = Console.ReadLine();
Console.WriteLine("----------------");
Console.WriteLine();

bool isValidInt = int.TryParse(ageText, out int age);
Console.WriteLine($"The input was valid: {isValidInt}. The number was {age}");

Console.Write("Your age in 25 years will be: ");
Console.WriteLine(age + 25);
Console.WriteLine();

Console.Write("Your age 25 years ago was: ");
Console.WriteLine(age - 25);
Console.ReadLine();