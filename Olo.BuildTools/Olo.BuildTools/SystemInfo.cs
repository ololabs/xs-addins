using System;
using System.IO;
using System.Linq;
using MonoDevelop.Core;

namespace Olo.BuildTools
{
	class SystemInfo : IApplication
	{
		public int Run(string[] arguments)
		{
			var systemInformationSummary = SystemInformation.GetTextDescription();

			if (!arguments.Any())
				printHelp();

			foreach (var argument in arguments)
			{
				if (argument == "-c")
					Console.WriteLine(systemInformationSummary);
				else if (argument == "-h")
					printHelp();
				else if (argument.StartsWith("-f:"))
					File.WriteAllText(argument.Substring(3), systemInformationSummary);
			}

			return 0;
		}

		private void printHelp()
		{
			Console.WriteLine();
			Console.WriteLine("System Info Tool");
			Console.WriteLine("Usage: mdtool systeminfo [-c] [-f:file-path]");
			Console.WriteLine();

			Console.WriteLine("Options");
			Console.WriteLine("  -h                Print this message");
			Console.WriteLine("  -c                Output system information to the console");
			Console.WriteLine("  -f:file-path      Output system information into the specifed file");
			Console.WriteLine();
		}
	}
}