using System;
namespace fioo{
    class fooClass{
	public static void Main(){
			Console.WriteLine(Foo(10));
			Console.ReadKey();
	}
		static 	int Foo(int n){
			if (n >= 0) {
				int[] arr = new int[n];
				arr [0] = 1;
				arr [1] = 1;
				if (n > 2) {
					for (int i = 2; i < n; i++) {
						arr [i] = arr [i - 1] + arr [i - 2];
					}
				}
				return arr[arr.Length-1];
			}
			else {
				return 0;
			}

	}
    }

}
