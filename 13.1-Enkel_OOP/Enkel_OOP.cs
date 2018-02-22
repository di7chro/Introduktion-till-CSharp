using System;

class Enkel_OOP {
	public static void Main() {
		Hund h = new Hund();
		Kanin k = new Kanin();
		Katt c = new Katt();

		h.namn = "Fido";
		Console.WriteLine("Hunden heter: " + h.namn);

		k.setName("Bambi");
		Console.WriteLine("Kaninen heter: " + k.getName());

		c.setName("Missen");
		Console.WriteLine("Katten heter: " + c.getName());

		Console.WriteLine("Allt klart...");
	}
}
