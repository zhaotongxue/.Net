using System;

namespace SeeMe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("程序现在开始执行");
			System.Threading.Thread bibime = new System.Threading.Thread (new System.Threading.ThreadStart(bibimetoseee));
			MainClass i = new MainClass ();
			System.Threading.Thread yousee = new System.Threading.Thread (new System.Threading.ThreadStart (i.There));
			Console.WriteLine ("已创建链接");
			bibime.Start ();
			yousee.Start ();
			System.Threading.Thread.Sleep (2000);
			Console.WriteLine ("我睡两秒钟");
			//yousee.Abort ();
			//Console.WriteLine ("Abort开始了");
			Console.ReadKey ();
			Console.WriteLine ("链接已打开");
			Console.ReadKey ();
*/
			Console.WriteLine ("MianClass的Main方法");
		}
		public static void bibimetoseee(){
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("轮到我了，快快快\nbibime已经开始执行");
 }
		void There(){
			System.Threading.Thread.Sleep(5000);
			Console.WriteLine("I am here\nThere已经开始执行");
		}
		protected static void Func(){
			Console.WriteLine("静态方法");
		}
		public void iFunc(){
			Console.WriteLine("实例方法");
		}
		public void iFunc(String abc){
			Console.WriteLine("重载的方法");
		}
	}

}
