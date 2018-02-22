using System;

class Exceptions {
	public static void Main() {
		int[] arr = new int[5];

		for (int i = 0; i < 5; i++) {
			arr[i] = i * 2;
		}
		Console.WriteLine("Innehallet i arrayen");
	
		try {
			for (int i = 0; i < 10; i++) {
				Console.WriteLine("Array[{0}]: {1}", i, arr[i]);
			}
		}
		catch (IndexOutOfRangeException iob) {
			Console.WriteLine("Du vet val att man inte kan loopa utanfor en array?");
			Console.WriteLine(iob);
		}
		catch (Exception ex) {
			Console.WriteLine("Nagot bidde fel");
			Console.WriteLine(ex);
		}
	}
}
