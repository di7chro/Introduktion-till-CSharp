using System;

public class Katt {
	private string namn;

	public Katt() {
		Console.WriteLine("Skapade en Katt");
	}

	public string getName() {
		return namn;
	}

	public void setName(string n) {
		namn = n;
	}
}

