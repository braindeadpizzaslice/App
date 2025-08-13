using System;

public class MainMenu
{
	public static void MainMenuMethod()
	{
        string[] mainmenuoptions = { "main menu", "Tilføj opgaver", "se alle opgaver\t", "afslut program\t" };
        int Mainmenuselect = 0;
        
        while (true)
		{
			Console.Clear();
			Console.CursorVisible = false;
            
			Console.SetCursorPosition((int)((Console.WindowWidth - mainmenuoptions[0].Length) / 2f), 1);


			for (int i = 0; i < mainmenuoptions.Length; i++)
			{

				Console.WriteLine((i == Mainmenuselect ? " * " : " * ") + mainmenuoptions[i] + (i == Mainmenuselect ? "<--" : ""));

			}
            var keypressed = Console.ReadKey(true);

            if (keypressed.Key == ConsoleKey.Q)
				{
					Environment.Exit(0);
				}
				if (keypressed.Key == ConsoleKey.DownArrow && Mainmenuselect != mainmenuoptions.Length - 1)
				{
					Mainmenuselect++;
				}
				else if (keypressed.Key == ConsoleKey.UpArrow && Mainmenuselect >= 1)
				{
					Mainmenuselect--;
				}
				else if (keypressed.Key == ConsoleKey.Enter) 
				{

					switch (Mainmenuselect)
					{
						case 1:
						OpgaveClass.OpgaveMethod();
						break;

					case 2:
						Environment.Exit(0);
						break;
						default:
							break;
					}
				}
            }

		}


	}

