/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 02/10/2014
 * Time: 07:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	/// <summary>
	/// Description of Productos.
	/// </summary>
	public class Productos
	{
		public Productos()
		{
		}
		
		private int cantidad1  = 0;
		private int cantidad2  = 0;
		private int cantidad3  = 0;
		private string descripcion1 = "";
		private string descripcion2 = "";
		private string descripcion3 = "";
		private double precio1 = 0;
		private double precio2 = 0;
		private double precio3 = 0;
		
		public void capturarTresProductos(){
			this.cantidad1 = asignarCantidad();
			this.descripcion1 = asignarDescripcion();
			this.precio1 = asignarPrecio();
			this.cantidad2 = asignarCantidad();
			this.descripcion2 = asignarDescripcion();
			this.precio2 = asignarPrecio();
			this.cantidad3 = asignarCantidad();
			this.descripcion3 = asignarDescripcion();
			this.precio3 = asignarPrecio();
			mostrarNota();
		}
		
		
		private int asignarCantidad()
		{
			Console.WriteLine();
			Console.WriteLine("Ingresa la cantidad del producto:");
			int cantidad = Int32.Parse( Console.ReadLine()  );
			return cantidad; 
		}
		
		private string asignarDescripcion()
		{
			Console.WriteLine("Ingresa la descripcion del producto:");
			string descripcion = Console.ReadLine();
			return descripcion; 
		}
		
		private double asignarPrecio()
		{
			Console.Write("Ingresa el precio unitario del producto: $");
			//Console.ReadKey(true);
			double precio = double.Parse( Console.ReadLine() );
			return precio; 
		}
		
		private void mostrarNota()
		{
			double subtotal1 = cantidad1*precio1;
			double subtotal2 = cantidad2*precio2;
			double subtotal3 = cantidad3*precio3;
			
			Console.WriteLine();
			Console.WriteLine("CANTIDAD DESCRIPCION     PRECIO ");
			Console.WriteLine();
			Console.WriteLine(" "+cantidad1+"    "+descripcion1+"      "+subtotal1);
			Console.WriteLine(" "+cantidad2+"    "+descripcion2+"      "+subtotal2);
			Console.WriteLine(" "+cantidad3+"    "+descripcion3+"      "+subtotal3);
			calcularIVA(subtotal1,subtotal2,subtotal3);
			Console.ReadKey(true);
		}
		
		private void calcularIVA(double subt1,double subt2,double subt3)
		{
			double subTotal = subt1+subt2+subt3;
			double iva = subTotal * 0.16;
			double total = subTotal + iva;
			Console.WriteLine("SUBTOTAL: $"+ subTotal);
			Console.WriteLine("IVA: $"+ iva);
			Console.WriteLine("TOTAL: $"+ total);
		}
		
	}
}
