
using System;

namespace Practica_4

{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("***B I E N V E N I D O***");
			
			
			Console.WriteLine("Lista de productos");
			
			
			string[] producto = new string[3];
			string[] codigo = new string[3];
			string[] descrip = new string[3];
			
			
			
			
			
			for (int i=0; i<3; i++)
			{
				    Console.WriteLine("Ingresa el producto ");
				 	producto[i]=Console.ReadLine();
				    
					
					Console.WriteLine("Ingresa el código ");
					codigo[i]=Console.ReadLine();
					
					Console.WriteLine("Ingresa la descripción ");
					descrip[i]=Console.ReadLine();
				
			}
			
			Console.WriteLine(" \n \n \n Tus registros son: \n");
			for (int i=0; i<3; i++)
			{
				Console.WriteLine("pruducto   "+producto[i]);
				Console.WriteLine("codigo   "+codigo[i]); 
				Console.WriteLine("descrip   "+descrip[i]); 	
				Console.WriteLine("\n \n"); 				
			}
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}