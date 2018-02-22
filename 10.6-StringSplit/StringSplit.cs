using System;

class StringSplit {
	public static void Main() {
		string listOfBeers = "Guinness, Vesper Ale, Dales Pale Ale, Snowcat, Punk IPA"; 
		char[] separators = new char[] { ',' };
		string[] beersArr = listOfBeers.Split(separators);

		foreach (var item in beersArr) {
			Console.WriteLine(item);
		}
	}
}
