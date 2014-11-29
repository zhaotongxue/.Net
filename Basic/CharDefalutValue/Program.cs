using System;

namespace CharDefalutValue
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		MainClass c=new MainClass();
			c.charDefalut ();
			Console.ReadKey ();
		}
	void charDefalut(){
		for(byte bs=0;bs<=200;bs++){
			Console.WriteLine(bs+":"+(char)bs);
		}
	}
	}
}
