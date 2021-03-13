using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Aplikasi Calculator";
			
			int selectMenu = SelectMenu();
			if (selectMenu < 1 || selectMenu > 4)
			{
				Console.WriteLine();
				Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
				ExitProgram();
			}
			
			Console.WriteLine();
			Console.Write("Inputkan nilai a: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Inputkan nilai b: ");
			int b = int.Parse(Console.Readline());
			
			Console.WriteLine();
			if (selectMenu == 1) Console.WriteLine($"Hasil penambahan {a} + {b} = {Penambahan(a, b)}");
			else if (selectMenu == 2) Console.WriteLine($"Hasil pengurangan {a} - {b} = {Pengurangan(a, b)}");
			else if (selectMenu == 3) Console.WriteLine($"Hasil perkalian {a} * {b} = {Perkalian(a, b)}");
			else Console.WriteLine($"Hasil pembagian {a} / {b} = {Pembagian(a, b)}");
			
			ExitProgram();
		}
		
		static int SelectMenu()
		{
			Console.WriteLine("Pilih Menu Kalkulator:);
			
			Console.WriteLine();
			Console.WriteLine("1. Penambahan");
			Console.WriteLine("2. Pengurangan");
			Console.WriteLine("3. Perkalian");
			Console.WriteLine("4. Pembagian");
			
			Console.WriteLine();
			Console.Write("Pilih [1 .. 4]: ");
			
			return int.Parse(Console.ReadLine());
		}
		
		static int Penambahan(int a, int b) => a + b;
		static int Pengurangan(int a, int b) => a - b;
		static int Perkalian(int a, int b) => a * b;
		static double int Pembagian(int a, int b) => (double) a / b;
		
		static void ExitProgram()
		{
			Console.WriteLine();
			Console.WriteLine("Tekan sembarang key untuk keluar");
			Console.ReadKey();
			
			Environment.Exit(0);
		}
	}
}