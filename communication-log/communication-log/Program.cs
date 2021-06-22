using System;

namespace communication_log
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Hello pilot");
            Console.WriteLine("Sup");
			Console.WriteLine("You are in restricted air space!");
			string YourMom = ("restricted air space!");
			Console.WriteLine("Very clever.");
            Console.WriteLine("Okay i'll stay out of " + YourMom );
			int divertNewCoordinates = 360;
			Console.WriteLine($"Please divert plane to {divertNewCoordinates} degrees");
		}
	}
}
