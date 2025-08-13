using System;

public class OpgaveClass
{
	public static void OpgaveMethod()
	{
		List<string> opgaveliste = new List<string>();
		
		

		while (true)
		{
			Console.WriteLine("what would you like to do?");
			Console.WriteLine("enter assignment");
			Console.WriteLine("show list");
			Console.WriteLine("manage assignments");
			Console.WriteLine("close program");
			Console.WriteLine("return");
			string userinpit = Console.ReadLine();
			string manageinput = Console.ReadLine();

			

			
			switch (userinpit)
			{
				case "assignment":
					
					Console.Clear();
					Console.WriteLine("insert your assignment you would like to add");
					string newassignment = Console.ReadLine();
					if (!string.IsNullOrEmpty(newassignment)) 
					{
						opgaveliste.Add(newassignment);
						Console.WriteLine("done");
						

						if (opgaveliste.Count >=5 )
						{
							Console.WriteLine("cant add anymore list is full");
						}
					}
					break;
				case "show list":
					Console.Clear();
					Console.WriteLine("heres the list");
					if (opgaveliste.Count == 0) 
					{
						Console.WriteLine("list is empty");
					}
					else
					{
						foreach (string i in opgaveliste) { Console.WriteLine(i); }
					}
					break ;
				case "manage":
					Console.Clear();
					Console.WriteLine("insert the item  you would like to have marked as finished ");
					manageinput = Console.ReadLine();
					if (opgaveliste.Contains (manageinput))
					{
					opgaveliste.Add(manageinput + "-finished task");
					opgaveliste.Remove(manageinput);
					}
					else
					{
						Console.WriteLine("item does not exist in the list");
					}
					break ;
				case "return":
					return;
					

				case "close program":
							Environment.Exit(0);
							break;

						default:
							break;
						}
		}
	}
    
}