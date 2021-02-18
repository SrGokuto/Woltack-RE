using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Woltack RE Mobile Version");
            Console.Write("Cargando");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Clear();
            //opciones string
            string opcion = "2";
            string o1 = "1";
            string o2 = "2";
            string o3 = "3";
            string o4 = "4";
            string o5 = "5";
            string o6 = "6";
            string o7 = "7";
            //variable de hora
            var Fecha = DateTime.Today.ToLongDateString();
            var hora = DateTime.Now.ToLongTimeString();
            //sistema de inicio
        while (opcion != o7){
        Console.WriteLine("Woltack Re Mobile Version");
        Console.WriteLine("By SrGokuto. Original By Wolder_YT");
        Console.WriteLine("Fecha de inicio: " + DateTime.Today.ToShortDateString() + " a las: " + DateTime.Now.ToShortTimeString());
        Console.WriteLine("");
        Console.WriteLine("Que desea hacer?");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("[1] Generar Links Discord Nitro");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("[2] Generar Gift Codes Discord Nitro");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[3] Generar Gift Codes Netflix");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[4] Generar Gift Codes Amazon");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[5] Generar Steam Codes");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[6] Generar Gift Codes Google Play");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(">>> ");
        opcion = Console.ReadLine();
        if (opcion == o1){
            string quantity = "";
            int cantidadlinks = 0;
            Console.WriteLine("Cuantos links quiere?");
            Console.WriteLine("[1] 100 [2] 1000 [3]10000 [4]100000 [5] 1000000");
Console.Write(">>> ");
            quantity = Console.ReadLine();
            if (quantity == o1){
                cantidadlinks = 100;
            }
            if (quantity == o2){
                cantidadlinks = 1000;
            }
            if (quantity == o3){
                cantidadlinks = 10000;
            }
            if (quantity == o4){
                cantidadlinks = 100000;
            }
            if (quantity == o5){
                cantidadlinks = 1000000;
            }
            while (cantidadlinks > 0){
            string nitrolink = "discord.gift/" + RandomString(24); 
            Console.WriteLine(nitrolink);
using (StreamWriter guardarlink = new StreamWriter("storage/emulated/0/Android/data/com.pwaltar.woltackre/Nitro links.txt", append: true))
                {
                    guardarlink.WriteLine(nitrolink);
                }
            cantidadlinks--;
        }
        Console.WriteLine("Nitro Links Generados y guardados en storage/emulated/0/Android/data/com.pwaltar.woltackre/Nitro links.txt");
        Console.WriteLine("Presiona una tecla para continuar");
        Console.ReadKey(true);
        Console.Clear();
        }
        if (opcion == o2){
            string quantity = "";
            int cantidadlinks = 0;
            Console.WriteLine("Cuantos Codes quiere?");
            Console.WriteLine("[1] 100 [2] 1000 [3]10000 [4]100000 [5] 1000000");
Console.Write(">>> ");
            quantity = Console.ReadLine();
            if (quantity == o1){
                cantidadlinks = 100;
            }
            if (quantity == o2){
                cantidadlinks = 1000;
            }
            if (quantity == o3){
                cantidadlinks = 10000;
            }
            if (quantity == o4){
                cantidadlinks = 100000;
            }
            if (quantity == o5){
                cantidadlinks = 1000000;
            }
            while (cantidadlinks > 0){
            	string codegift = RandomString2(4) + "-" + RandomString2(5) + "-" + RandomString2(5) + "-" + RandomString2(5) + "-" + RandomString2(5);
            Console.WriteLine(codegift);
using (StreamWriter guardarlink = new StreamWriter("storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Nitro.txt", append: true))
                {
                    guardarlink.WriteLine(codegift);
                }
            cantidadlinks--;
        }
        Console.WriteLine("Nitro Codes Generados y guardados en storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Nitro.txt");
        Console.WriteLine("Presiona una tecla para continuar");
        Console.ReadKey(true);
        Console.Clear();
        }	
        if (opcion == o3){
            string quantity = "";
            int cantidadlinks = 0;
            Console.WriteLine("Cuantos Codes quiere?");
            Console.WriteLine("[1] 100 [2] 1000 [3]10000 [4]100000 [5] 1000000");
Console.Write(">>> ");
            quantity = Console.ReadLine();
            if (quantity == o1){
                cantidadlinks = 100;
            }
            if (quantity == o2){
                cantidadlinks = 1000;
            }
            if (quantity == o3){
                cantidadlinks = 10000;
            }
            if (quantity == o4){
                cantidadlinks = 100000;
            }
            if (quantity == o5){
                cantidadlinks = 1000000;
            }
            while (cantidadlinks > 0){
            	string codegift = RandomString2(4) + "-" + RandomString2(6) + "-" + RandomString2(4);
            Console.WriteLine(codegift);
using (StreamWriter guardarlink = new StreamWriter("storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Netflix.txt", append: true))
                {
                    guardarlink.WriteLine(codegift);
                }
            cantidadlinks--;
        }
        Console.WriteLine("Netflix Codes Generados y guardados en storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Netflix.txt");
        Console.WriteLine("Presiona una tecla para continuar");
        Console.ReadKey(true);
        Console.Clear();
        }
        if (opcion == o4){
            string quantity = "";
            int cantidadlinks = 0;
            Console.WriteLine("Cuantos Codes quiere?");
            Console.WriteLine("[1] 100 [2] 1000 [3]10000 [4]100000 [5] 1000000");
Console.Write(">>> ");
            quantity = Console.ReadLine();
            if (quantity == o1){
                cantidadlinks = 100;
            }
            if (quantity == o2){
                cantidadlinks = 1000;
            }
            if (quantity == o3){
                cantidadlinks = 10000;
            }
            if (quantity == o4){
                cantidadlinks = 100000;
            }
            if (quantity == o5){
                cantidadlinks = 1000000;
            }
            while (cantidadlinks > 0){
            	string codegift = RandomString2(4) + "-" + RandomString2(6) + "-" + RandomString2(4);
            Console.WriteLine(codegift);
using (StreamWriter guardarlink = new StreamWriter("storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Amazon.txt", append: true))
                {
                    guardarlink.WriteLine(codegift);
                }
            cantidadlinks--;
        }
        Console.WriteLine("Amazon Codes Generados y guardados en storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Amazon.txt");
        Console.WriteLine("Presiona una tecla para continuar");
        Console.ReadKey(true);
        Console.Clear();
        }
        if (opcion == o5){
            string quantity = "";
            int cantidadlinks = 0;
            Console.WriteLine("Cuantos Codes quiere?");
            Console.WriteLine("[1] 100 [2] 1000 [3]10000 [4]100000 [5] 1000000");
Console.Write(">>> ");
            quantity = Console.ReadLine();
            if (quantity == o1){
                cantidadlinks = 100;
            }
            if (quantity == o2){
                cantidadlinks = 1000;
            }
            if (quantity == o3){
                cantidadlinks = 10000;
            }
            if (quantity == o4){
                cantidadlinks = 100000;
            }
            if (quantity == o5){
                cantidadlinks = 1000000;
            }
            while (cantidadlinks > 0){
            	string codegift = RandomString2(5) + "-" + RandomString2(5) + "-" + RandomString2(5);
            Console.WriteLine(codegift);
using (StreamWriter guardarlink = new StreamWriter("storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Steam.txt", append: true))
                {
                    guardarlink.WriteLine(codegift);
                }
            cantidadlinks--;
        }
        Console.WriteLine("Steam Codes Generados y guardados en storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Steam.txt");
        Console.WriteLine("Presiona una tecla para continuar");
        Console.ReadKey(true);
        Console.Clear();
        }
        if (opcion == o6){
            string quantity = "";
            int cantidadlinks = 0;
            Console.WriteLine("Cuantos Codes quiere?");
            Console.WriteLine("[1] 100 [2] 1000 [3]10000 [4]100000 [5] 1000000");
Console.Write(">>> ");
            quantity = Console.ReadLine();
            if (quantity == o1){
                cantidadlinks = 100;
            }
            if (quantity == o2){
                cantidadlinks = 1000;
            }
            if (quantity == o3){
                cantidadlinks = 10000;
            }
            if (quantity == o4){
                cantidadlinks = 100000;
            }
            if (quantity == o5){
                cantidadlinks = 1000000;
            }
            while (cantidadlinks > 0){
            	string codegift = RandomString2(4) + "-" + RandomString2(4) + "-" + RandomString2(4) + "-" + RandomString2(4) + "-" + RandomString2(4);
            Console.WriteLine(codegift);
using (StreamWriter guardarlink = new StreamWriter("storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Google Play.txt", append: true))
                {
                    guardarlink.WriteLine(codegift);
                }
            cantidadlinks--;
        }
        Console.WriteLine("Google Play Codes Generados y guardados en storage/emulated/0/Android/data/com.pwaltar.woltackre/Codes Google Play.txt");
        Console.WriteLine("Presiona una tecla para continuar");
        Console.ReadKey(true);
        Console.Clear();
        }
        }
        }
        public static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomString2(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        }
    }
