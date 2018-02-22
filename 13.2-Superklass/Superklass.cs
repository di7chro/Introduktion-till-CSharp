using System;

class Superklass {
	public static void Main() {
		Hund h = new Hund();
		Kanin k = new Kanin();
		Katt c = new Katt();

		h.setNamn("Fido");
		h.setVikt(18);

		k.setNamn("Bambi");
		k.setVikt(2);

		c.setNamn("Misse");
		c.setVikt(7);

		Console.WriteLine("Hunden {0} har vikten {1}kg", h.getNamn(), h.getVikt());
		Console.WriteLine("Kaninen {0} har vikten {1}kg", k.getNamn(), k.getVikt());
		Console.WriteLine("Katten {0} har vikten {1}kg", c.getNamn(), c.getVikt());

		h.geLjud();
		k.geLjud();
		c.geLjud();

		k.idissla();
	}
}
