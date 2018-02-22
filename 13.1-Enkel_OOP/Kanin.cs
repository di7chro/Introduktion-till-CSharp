using System;

public class Kanin {
	private string namn;

	public Kanin() {
		Console.WriteLine("Skapade en Kanin");
	}

	public string getName() {
		return namn;
	}

	public void setName(string n) {
		namn = n;
	}
}

