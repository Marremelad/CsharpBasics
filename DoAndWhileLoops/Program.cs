// string? readResult;
// int numericValue = 0;
// bool validValue = false;

// Console.WriteLine("Please enter an integer between 5 and 10.");


// do
// {
//     readResult = Console.ReadLine();
//     validValue = int.TryParse(readResult, out numericValue);
    
//     if (validValue == true) {
//         if (numericValue < 5 || numericValue > 10) {
//             validValue = false;
//             Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
//         }
//     }
    
//     else {
//         Console.WriteLine("Not a number.");
//     }
// }
// while (validValue == false);

// Console.WriteLine($"Your value of {numericValue} has been accepted.");

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim().ToLower();
//     }

//     if (roleName == "administrator" || roleName == "manager" || roleName == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}