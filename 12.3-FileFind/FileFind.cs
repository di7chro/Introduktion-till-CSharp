using System;
using System.IO;

class FileFind {
	public static void Main() {
		string fileName = "../../bacon.txt";
		string word = "pork";

		try {
			StreamReader reader = new StreamReader(fileName);
			int occurences = 0;

			string line = reader.ReadLine();

			while (line != null) {
				int index = line.IndexOf(word);
				while (index != -1) {
					occurences++;
					index = line.IndexOf(word, (index + 1));
				}
				line = reader.ReadLine();
			}
			Console.WriteLine("Ordet \"{0}\" fanns med {1} i filen: {2}", word, occurences, fileName);
			reader.Close();
		}
		catch (FileNotFoundException fnf) {
			Console.WriteLine("Kunde inte oppna filen: {0}", fileName);
			Console.WriteLine(fnf);
		}
		catch (IOException ioex) {
			Console.WriteLine("Kan inte lasa fran filen: {0}", fileName);
			Console.WriteLine(ioex);
		}

		Console.WriteLine("Allt klart...");
	}
}
