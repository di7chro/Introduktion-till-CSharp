using System;

class Scope {
	public static int classVar = 325;

	public static void do_something(int indata) {
		Console.WriteLine("ClassVar i do_something: {0}", classVar);
		Console.WriteLine("Indata: {0}", indata);
	}

	public static void Main() {
		int funkVar = 10;

		for (int i = 0; i < 4; i++) {
			Console.WriteLine("Variabeln i={0}", i);
		}
		if (funkVar > 7) {
			int ifVar = 65;
			Console.WriteLine("ifVar:" + ifVar);
		}

		Console.WriteLine("Funkvar: {0}", funkVar);
		//Console.WriteLine("Raknaren i: {0}", i);
		//Console.WriteLine("ifVar: {0}", ifVar);
		//Console.WriteLine("SistVar: {0}", sistVar);
		//int sistVar = 564;
		Console.WriteLine("ClassVar: {0}", classVar);

		do_something(111);

		Console.WriteLine("Indata:{0}", indata);
	}
}
