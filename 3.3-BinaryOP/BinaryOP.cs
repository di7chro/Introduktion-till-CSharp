using System;

class BinaryOP {
	static void printBinary(byte tal) {
		Console.WriteLine("Talet: 0x{0}", Convert.ToString(tal, 2).PadLeft(8, '0'));
	}

	public static void Main() {
		byte tal = 54;		// 0011 0110 = 54
		byte a = 3;			// 0000 0011 = 3
		byte b = 5;			// 0000 0101 = 5 

		printBinary(tal);

		Console.WriteLine(a | b);   // 0000 0111 = 7 
		Console.WriteLine(a & b);   // 0000 0001 = 1 
		Console.WriteLine(a ^ b);   // 0000 0110 = 6 
		Console.WriteLine(~a & b);  // 0000 0100 = 4 
		Console.WriteLine(a << 1);  // 0000 0110 = 6 
		Console.WriteLine(a << 2);  // 0000 1100 = 12 
		Console.WriteLine(a >> 1);  // 0000 0001 = 1


	}
}
