## First things to do

1. Create a new folder and name it
   1. This folder will be used to create a single application file inside it
   1. The folder's name will be used in another file for future compilation, then be careful when you need to rename it
1. Select the folder: `cd <folder_name>`

## Creating a program in C#

`dotnet new console --framework net6.0`

The project template creates a simple application that displays "Hello World" in the console window by calling the `Console.WriteLine(String)` method in `Program.cs`.

## Run the program

Once created the `Program.cs` file and all subjacent structures, you can edit `Program.cs` with your code. For running the program use the command:

`dotnet run`
