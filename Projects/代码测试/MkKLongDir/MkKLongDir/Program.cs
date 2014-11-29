using System;
using System.IO;

namespace MkKLongDir
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string path="/mnt/软件";

			//DirectoryInfo d = new DirectoryInfo (path);

			for (int i=0; i<265; i++) {
				Console.Write ("/265");
			}
			int c = 266;
			do{
				for(int i=10000;i>0;i--){
					if(Directory.Exists(path+"/"+c)){
						path+="/"+c;
					}
					else{
						c--;
					}
					if(Directory.GetDirectories(path).Length==0){
						Directory.Delete(path);
					}
				}
			}
			while(Directory.GetDirectories("/mnt/软件/266").Length==0);
		
	
	}
}
}