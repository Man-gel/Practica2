/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 30/09/2014
 * Time: 06:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	class Program
	{
		private static int cantidad1  = 0;
		private static int cantidad2  = 0;
		private static int cantidad3  = 0;
		
		public  static int asignarCantidad()
		{
			Console.WriteLine("Ingresa la cantidad del producto:");
			int cantidad = Int32.Parse( Console.ReadLine()  );
			return cantidad; 
		}
		
		
		public static void Main(string[] args)
		{
			cantidad1 = asignarCantidad();
			cantidad2 = asignarCantidad();
			cantidad3 = asignarCantidad();
			//Console.WriteLine("c1: "+cantidad1+" c2: "+cantidad2+" c3: "+cantidad3);
			//Console.ReadKey(true);
			
		}
	}
}