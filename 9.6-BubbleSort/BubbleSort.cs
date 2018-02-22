using System;

class BubbleSort {
	const int SIZE = 10, MIN = 0, MAX = 100;

	public static void Main() {
		Random rand = new Random();
		short[] myArray = new short[SIZE];

		for (int i = 0; i < SIZE; i++) {
			myArray[i] = (short)rand.Next(MIN, MAX);
		}

		Console.WriteLine("--------- myArray fore sortering ------------");
		for (int i = 0; i < SIZE; i++) {
			Console.WriteLine("myArray[{0}]= {1}", i, myArray[i]);
		}

		myBubbleSort(myArray);

		Console.WriteLine("--------- myArray efter sortering ------------");
		for (int i = 0; i < SIZE; i++) {
			Console.WriteLine("myArray[{0}]= {1}", i, myArray[i]);
		}
	}

	static void myBubbleSort(short[] arr) {
		short temp = 0;

		for (int walker = 0; walker < arr.Length; walker++) {
			for (int sorter = 0; sorter < arr.Length - 1; sorter++) {
				if (arr[sorter] > arr[sorter + 1]) {
					temp = arr[sorter + 1];
					arr[sorter + 1] = arr[sorter];
					arr[sorter] = temp;
				}
			}
		}
	}
}



