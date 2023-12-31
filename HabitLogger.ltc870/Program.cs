using Spectre.Console;

//CreateDatabase();

MainMenu();

void MainMenu()
{
    var isMenuRunning = true;

    while (isMenuRunning)
    {
        var usersChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("What would you like to do?")
            .AddChoices(
                "Add Record",
                "Delete Record",
                "View Records",
                "Update Record",
                "Quit")
            );

        switch (usersChoice)
        {
            case "Add Record":
                //AddRecord();
                break;
            case "Delete Record":
                //DeleteRecord();
                break;
            case "View Records":
                //ViewRecords();
                break;
            case "Update Record":
                //UpdateRecord();
                break;
            case "Quit":
                Console.WriteLine("Goodbye!");
                isMenuRunning = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose one from above.");
                break;
        }
    }
}

