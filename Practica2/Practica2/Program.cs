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
		private static double precio1 = 0;
		private static double precio2 = 0;
		private static double precio3 = 0;
		
		
		public  static int asignarCantidad()
		{
			Console.WriteLine();
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
		
		public  static double asignarPrecio()
		{
			Console.Write("Ingresa el precio unitario del producto: $");
			//Console.ReadKey(true);
			double precio = double.Parse( Console.ReadLine() );
			return precio; 
		}
		
		public static void mostrarNota()
		{
		double subtotal1 = cantidad1*precio1;
		double subtotal2 = cantidad2*precio2;
		double subtotal3 = cantidad3*precio3; 
			Console.WriteLine("CANTIDAD DESCRIPCION     PRECIO ");
			Console.WriteLine();
			Console.WriteLine(" "+cantidad1+"    "+descripcion1+"      "+subtotal1);
			Console.WriteLine(" "+cantidad2+"    "+descripcion2+"      "+subtotal2);
			Console.WriteLine(" "+cantidad3+"    "+descripcion3+"      "+subtotal3);
			calcularIVA(subtotal1,subtotal2,subtotal3);
			Console.ReadKey(true);
		}
		
		private static void calcularIVA(double subt1,double subt2,double subt3)
		{
			double subTotal = subt1+subt2+subt3;
			double iva = subTotal * 0.16;
			double total = subTotal + iva;
			Console.WriteLine("SUBTOTAL: "+ subTotal);
			Console.WriteLine("IVA: "+ iva);
			Console.WriteLine("TOTAL: "+ total);
			
		}
		
		
		
		public static void Main(string[] args)
		{
			cantidad1 = asignarCantidad();
			descripcion1 = asignarDescripcion();
			precio1 = asignarPrecio();
			cantidad2 = asignarCantidad();
			descripcion2 = asignarDescripcion();
			precio2 = asignarPrecio();
			cantidad3 = asignarCantidad();
			descripcion3 = asignarDescripcion();
			precio3 = asignarPrecio();
			mostrarNota();
			
			//Console.WriteLine("Prd1: "+descripcion1+" cant: "+cantidad1+" Precio: "+precio1);
			//Console.WriteLine("Prd2: "+descripcion2+" cant: "+cantidad2+" Precio: "+precio2);
			//Console.WriteLine("Prd3: "+descripcion3+" cant: "+cantidad3+" Precio: "+precio3);
			//Console.ReadKey(true);
			
		}
	}
}