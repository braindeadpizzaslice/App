using System;

public class OpgaveClass
{
	public static void OpgaveMethod()
	{
		List<string> opgaveliste = new List<string>();
		
		

		while (true)
		{
			Console.WriteLine("what would you like to do?");
			Console.WriteLine("type in what you would like to do or the corresponding number");
			Console.WriteLine("1->enter assignment");
			Console.WriteLine("2->show list");
			Console.WriteLine("3->manage assignments");
			Console.WriteLine("4->return to main menu");
			Console.WriteLine("5->close program");
			string userinput = Console.ReadLine();





			switch (userinput)
			{
                //the user might find it easier to shorten assignment so making sure other options work aswell show and list all work
                //doing the same for the other cases aswell
                case "assignment":
				case "task":
				case "job":
				case "role":
				case "1":


					Console.Clear();
					Console.WriteLine("insert your assignment you would like to add");
					string newassignment = Console.ReadLine();
					if (!string.IsNullOrEmpty(newassignment))
					{
						opgaveliste.Add(newassignment);
						Console.WriteLine("done");
						Console.Clear() ;


						if (opgaveliste.Count >= 5)
						{
							Console.WriteLine("cant add anymore list is full");
						}
					}
					break;
					
				case "show list":
				case "show":
				case "list":
				case "2":
					Console.Clear();
					
					
					if (opgaveliste.Count == 0)
					{
						Console.WriteLine("list is empty");
					}
					else
					{
                        Console.WriteLine("heres the list");
                        foreach (string i in opgaveliste) { Console.WriteLine(i); }
					}
				
			Console.WriteLine("would you like to return to the main menu?");
					
			Console.ReadKey(true);
					Console.Clear();
			break;
					
				case "manage":
				case "manage assignment":
				case "3":
					Console.Clear();
					Console.WriteLine("insert the item  you would like to have marked as finished ");
					
					userinput = Console.ReadLine();
					if (opgaveliste.Contains (userinput))
					{
					opgaveliste.Add(userinput + "-finished task");
					opgaveliste.Remove(userinput);
						Console.Clear();
					}
					else
					{
						Console.WriteLine("item does not exist in the list");
						Console.ReadLine();
						Console.Clear();
					}
					break ;
				case "return ":
				case "4":
				case "return to main menu":
					Console.Clear();
					MainMenu.MainMenuMethod();
					break ;
					

				case "close program":
				case "close":
				case "5":
					Environment.Exit(0);
					return;

				default:
					break;
				}
		}
	}
    
}