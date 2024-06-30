using System.Runtime.CompilerServices;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
// the ourAnimals array will store the following: 

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
bool isComplete = false;
// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i) {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
    
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
    
        case 2:    
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:    
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;    
    
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do 
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection) {
        case "1":
        // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        Console.WriteLine();
                        for (int j = 0; j < 6; j++)
                        {
                            Console.WriteLine(ourAnimals[i, j]);
                        }
                    }
                }
            break;
        
        case "2":
            string anotherPet = "y";
            int petCount = 0;
            
            for (int i = 0; i < maxPets; i++) {
                
                if (ourAnimals[i, 0] != "ID #: ") {
                        petCount += 1;
                }
            }

            if (petCount < maxPets) {
                
                while (anotherPet == "y" && petCount < maxPets) {

                    bool validEntry = false;

                    do {
                        Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin new entry");
                        readResult = Console.ReadLine();

                        if (readResult != null) {
                            animalSpecies = readResult.ToLower();
                        

                            if (animalSpecies != "dog" && animalSpecies != "cat") {
                                validEntry = false;
                            }
                            else {
                                validEntry = true;
                                animalID = animalSpecies.Substring(0, 1) +(petCount + 1).ToString();
                            }
                    
                        }
                    
                    } while (validEntry == false);

                    do {
                        int petAge;
                        Console.WriteLine("Enter the pet's age or enter ? if unknown");
                        readResult = Console.ReadLine();
                        if (readResult != null) {
                            animalAge = readResult;
                            if (animalAge != "?") {
                                validEntry = int.TryParse(animalAge, out petAge); // animalAge is being parsed. Value is stored in petAge.
                                //boolean value is stored in validEntry.
                            }
                            else {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    do {
                        Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                        readResult = Console.ReadLine();
                        if (readResult != null) {
                            animalPhysicalDescription = readResult.ToLower();
                            if (animalPhysicalDescription == "") {
                                animalPhysicalDescription = "tbd";
                            }
                        }
                    } while (animalPhysicalDescription == "");

                    do {
                        Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                        readResult = Console.ReadLine();
                        if (readResult != null) {
                            animalPersonalityDescription = readResult.ToLower();
                            if (animalPersonalityDescription == "") {
                                animalPersonalityDescription = "tbd";
                            }
                        }
                    
                    do {
                        Console.WriteLine("Enter a nickname for the pet");
                        readResult = Console.ReadLine();
                        if (readResult != null) {
                            animalNickname = readResult.ToLower();
                            if (animalNickname == "") {
                                animalNickname = "tbd";
                            }
                        }
                    } while (animalNickname == "");

                    // store the pet information in the ourAnimals array (zero based)
                    ourAnimals[petCount, 0] = "ID #: " + animalID;
                    ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                    ourAnimals[petCount, 2] = "Age: " + animalAge;
                    ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                    ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                    ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;


                    } while(animalPersonalityDescription == "");

                        petCount = petCount + 1;

                        if (petCount < maxPets) {
                            
                            Console.WriteLine("Do you want to enter info for another pet (y/n)");
                            
                            do {
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    anotherPet = readResult.ToLower();
                                    
                                }

                            } while (anotherPet != "y" && anotherPet != "n");
                        }
                    }

                    if (petCount >= maxPets)
                    {
                        Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                    }
            
            
            Console.WriteLine("Press enter to continue");                    }
            break;

        case "3":
        // Ensure animal ages and physical descriptions are complete
            for (int i = 0; i < maxPets; i++) {   
                if (ourAnimals[i, 0] != "ID #: ") {                    
                    if (ourAnimals[i, 2] == "Age: ?" || ourAnimals[i, 4] == "Physical description: " || ourAnimals[i, 4] == "Physical description: tbd") {
                        if (ourAnimals[i, 2] == "Age: ?") {
                            bool isInteger = true;
                            int petAge;
                            do {                               
                                Console.WriteLine($"{ourAnimals[i, 0]} is missing age. Please input");
                                readResult = Console.ReadLine();                               
                                if (readResult != null) {                                  
                                    isInteger = int.TryParse(readResult, out petAge);                                  
                                    if (isInteger) {                                       
                                        ourAnimals[i, 2] = "Age: " + petAge;
                                    }                                 
                                    else {                                
                                        Console.WriteLine("Not a number");
                                    }                                   
                                }
                            } while (isInteger == false);                           
                        }                       
                        if (ourAnimals[i, 4] == "Physical description: " || ourAnimals[i, 4] == "Physical description: tbd") {
                            bool isString = false;
                            Console.WriteLine($"{ourAnimals[i, 0]} is Missing physical description. Please input");
                            do {                             
                                readResult = Console.ReadLine();
                                isString = String.IsNullOrEmpty(readResult);
                                if (isString) {
                                    Console.WriteLine("Please enter a physical description");
                                }
                                else {
                                    ourAnimals[i, 4] = "Physical description: " + readResult;
                                }
                            } while (isString == true);
                            
                        }
                    }
                    else {
                        isComplete = true;
                    }
                }
            }
            if (isComplete == true) {
                Console.WriteLine("Entries for age and physical description are completed");
            }
            break;

        case "4":
        // Ensure animal nicknames and personality descriptions are complete
            for (int i = 0; i < maxPets; i++) {
                if (ourAnimals[i, 0] != "ID #: ") {
                    if (ourAnimals[i, 3] == "Nickname: " || ourAnimals[i, 3] == "Nickname: tbd" || ourAnimals[i, 5] == "Personality: " || ourAnimals[i, 5] == "Personality: tbd") {
                        bool isString = false;
                        if (ourAnimals[i, 3] == "Nickname: " || ourAnimals[i, 3] == "Nickname: tbd") {
                            Console.WriteLine($"{ourAnimals[i, 0]} is missing a nickname. Please input.");
                            do {
                                readResult = Console.ReadLine();
                                isString = String.IsNullOrEmpty(readResult);
                                if (isString) {
                                    Console.WriteLine("Please enter a nickname");
                                }
                                else {
                                    ourAnimals[i, 3] = "Nickaname" + readResult;
                                }

                            } while (isString);
                        }
                        if (ourAnimals[i, 5] == "Personality: " || ourAnimals[i, 5] == "Personality: tbd") {
                            Console.WriteLine($"{ourAnimals[i, 0]} is missing a personality description. Please input.");
                            do {
                                readResult = Console.ReadLine();
                                isString = String.IsNullOrEmpty(readResult);
                                if (isString) {
                                    Console.WriteLine("Please enter a personality description");
                                }
                                else {
                                    ourAnimals[i, 5] = "Personality: " + readResult;
                                }
                            } while(isString);    
                        }         
                    }
                    else {
                        isComplete = true;
                    }
                }    
            }
            if (isComplete == true) {
                Console.WriteLine("Entries for nickname and personality are completed");
            }
            break;

        case "5":
        // Edit an animal’s age
            Console.WriteLine("Placeholder");
            Console.WriteLine("Press the Enter key to continue");
            break;

        case "6":
        // Edit an animal’s personality description
            Console.WriteLine("Placeholder");
            Console.WriteLine("Press the Enter key to continue");
            break;

        case "7":
        // Display all cats with a specified characteristic
            Console.WriteLine("Placeholder");
            Console.WriteLine("Press the Enter key to continue");
            break;

        case "8":
        // Display all dogs with a specified characteristic
            Console.WriteLine("Placeholder");
            Console.WriteLine("Press the Enter key to continue");
            break;
        
        case "exit":
        Console.WriteLine("Press enter to exit program");
            break;
        
        default:
            Console.WriteLine("Invalid input");
            Console.WriteLine("Press the Enter key to continue");
            break;

    }
    // pause code execution
    readResult = Console.ReadLine();
} while (menuSelection != "exit");

// Pet app exercise