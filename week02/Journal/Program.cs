using System;

Journal theJournal = new Journal();
PromptGenerator Prompt = new PromptGenerator();

string choice = "";

while (choice != "5")
{
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display the journal");
    Console.WriteLine("3. Save the journal");
    Console.WriteLine("4. Load the journal");
    Console.WriteLine("5. Quit");

    Console.Write("What would you like to do? ");
    choice = Console.ReadLine();

   if (choice == "1")
    {
        string promptText = Prompt.GetRandomPrompt();

        Console.WriteLine(promptText);
        Console.Write("> ");
        string response = Console.ReadLine();

        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToShortDateString();

        Entry newEntry = new Entry();

        newEntry._date = date;
        newEntry._prompt = promptText;
        newEntry._entryText = response;

        theJournal.AddEntry(newEntry);
    }
    else if (choice == "2")
    {
        theJournal.DisplayAll();
    }
    else if (choice == "3")
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        theJournal.SaveToFile(filename);

        Console.WriteLine("Journal saved successfully.");
    }
    else if (choice == "4")
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        theJournal.LoadFromFile(filename);

        Console.WriteLine("Journal loaded successfully.");
    }
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye!");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
    Console.WriteLine();

}
