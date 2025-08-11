using System;

public class MainMenu
{
	public static void MainMenuMethod()
	{
		while (true)
		{
			//main menu class that guides the user through the software 
			string[] mainmenuoptions = { "Main Menu\t", "Tilføj opgaver", "se alle opgaver\t", "afslut program\t" };
            Console.CursorVisible = false;
			Console.SetCursorPosition((int)((Console.WindowWidth - mainmenuoptions[0].Length) / 2f), 1);


			


            int mainmenuselect = 0;

			foreach (string option in mainmenuoptions)
			{
				Console.WriteLine(option);
			
			}

		}


	}
}
