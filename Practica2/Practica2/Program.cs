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
		private static string descripcion1 = "";
		private static string descripcion2 = "";
		private static string descripcion3 = "";
		
		
		public  static int asignarCantidad()
		{
			Console.WriteLine("Ingresa la cantidad del producto:");
			int cantidad = Int32.Parse( Console.ReadLine()  );
			return cantidad; 
		}
		
		public  static string asignarDescripcion()
		{
			Console.WriteLine("Ingresa la descripcion del producto:");
			string descripcion = Console.ReadLine();
			return descripcion; 
		}
		
		
		
		public static void Main(string[] args)
		{
			cantidad1 = asignarCantidad();
			descripcion1 = asignarDescripcion();
			cantidad2 = asignarCantidad();
			descripcion2 = asignarDescripcion();
			cantidad3 = asignarCantidad();
			descripcion3 = asignarDescripcion();
			Console.WriteLine("d1: "+descripcion1+" d2: "+descripcion2+" d3: "+descripcion3);
			//Console.WriteLine("c1: "+cantidad1+" c2: "+cantidad2+" c3: "+cantidad3);
			Console.ReadKey(true);
			
		}
	}
}