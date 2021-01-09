# FocusLogger
A debugging tool that logs the title of the Window that is in focus. This is useful for debugging in situtations where a window is stealing focus when a hotkey is pressed.

## Usage

1. Build the program using `dotnet build` and run the compiled exe file.
2. Run the exe file. You may point the output to a file, if yo do not wish it to appear on the command line.
`.\FocusLogger.exe`
or
`.\FocusLogger.exe > somelogfile.txt`
3. Kill the program using CTRL + C when you are finished.
