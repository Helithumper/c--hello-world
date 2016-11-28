using System;

namespace helloworld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] list = new int[1000];

			for (int i = 0; i < list.Length; i++) {
				list [i] = i;
			}

			Console.WriteLine ("DONE writing");

			foreach (int i in list) {
				Console.WriteLine (i);
			}
			Console.WriteLine ("TYPE SOMETHING!!");
			String userinput = Console.In.ReadLine ();
			Console.WriteLine (userinput);

		}
	}
}
