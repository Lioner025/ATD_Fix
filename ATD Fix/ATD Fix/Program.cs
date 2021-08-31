/*
 * Creado por SharpDevelop.
 * Usuario: Lioner
 * Fecha: 05/09/2021
 * Hora: 1:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace ATD_Fix
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("   ____________________________________________________");
				Console.WriteLine("-=|ATD_Fix por @Lioner025 para purgar el caché residual|=-");
				Console.WriteLine("   ****************************************************");
				Console.WriteLine();
				
			string a  = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
				
			Directory.GetAccessControl(@"C:\");
			Directory.Delete(a+@"\AppData\Local\ATDS3",true);
			Directory.Delete(a+@"\AppData\Roaming\ATDS3",true);
			Console.Write("Purga de Caché realizada Con Éxito");
			Console.ReadLine();
			}
			catch(Exception e)
			{
				if(e is DirectoryNotFoundException)
				Console.WriteLine("No es necesario proceder, El Caché ya está purgado");
				else if(e is UnauthorizedAccessException)
				Console.WriteLine("Error :\nEl ATD debe estar cerrado antes de proceder con la purga del caché");	
                Console.ReadLine();				
			}
			
			
		}
	}
}