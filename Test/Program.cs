// get the pet's age. can be ? at initial entry.
string readResult;
int animalAge = 0;
bool validEntry = false;

do
{
    int petAge;
    Console.WriteLine("Enter the pet's age or enter ? if unknown");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        animalAge = readResult;
        if (animalAge != "?")
        {
            validEntry = int.TryParse(animalAge, out petAge);
        }
        else
        {
            validEntry = true;
        }
    }
} while (validEntry == false);