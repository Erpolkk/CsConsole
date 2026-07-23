# CsConsole
This is a Console on C# For Begginers

How to Add New Commands
To add a new command to the console, follow these steps:

Create the command check: Add a new if statement in the main loop:

C#
if (inputconsole == "YOUR_COMMAND")
{
    // YOUR COMMAND CODE HERE
}
Update the UI/Help: Don't forget to add your command to the help command list so users know it exists, and update the info section if needed.

Handle input logic: Make sure to handle spaces and additional conditions if your command requires them (e.g., adding && inputconsole != "YOUR_COMMAND" where necessary).

How to Rename a Command
To change an existing command name:

Find the if block containing the command.

Change the string inside the quotes (e.g., == "OLD_COMMAND" to == "NEW_COMMAND").

Update any related conditions or checks at the end of the function if needed.
