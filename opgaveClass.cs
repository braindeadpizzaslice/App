using System;

public class OpgaveClass
{
	public static void OpgaveMethod()
	{
		List<string> opgaveliste = new List<string>();
		Console.WriteLine("please do input your assignments here");
		string userinpit = Console.ReadLine();

		opgaveliste.Add(userinpit);
		Console.WriteLine(userinpit);
		
	}
}
