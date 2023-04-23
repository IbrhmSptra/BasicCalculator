using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2= 0;
            double result = 0;
            bool coba_lagi = true;

            while (coba_lagi) {
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("                     KALKULATOR");
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine();
            System.Console.Write("Masukan Angka Pertama : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("Masukan Angka Kedua : ");
            num2 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine("-------------------------------------------");
            System.Console.WriteLine("Pilih Sistem Operasi Yang diinginkan : ");
            System.Console.WriteLine("\t (-) = Pengurangan");
            System.Console.WriteLine("\t (+) = Penjumlahan");
            System.Console.WriteLine("\t (x) = Perkalian");
            System.Console.WriteLine("\t (/) = Pembagian");
            System.Console.WriteLine("\t (^) = Pemangkatan");
            System.Console.WriteLine("-------------------------------------------");
            System.Console.Write("Ketik Disini . . .");
            switch (Console.ReadLine().ToUpper()) {
                case "-" :
                result = num1 - num2;
                System.Console.WriteLine("--------------------------------------------");
                System.Console.WriteLine("Hasil " +num1 + " - " + num2 + " = " + result);
                System.Console.WriteLine("--------------------------------------------");
                break;
                case "+" :
                result = num1 + num2;
                System.Console.WriteLine("--------------------------------------------");
                System.Console.WriteLine("Hasil " +num1 + " + " + num2 + " = " + result);
                System.Console.WriteLine("--------------------------------------------");
                break;
                case "X" :
                result = num1 * num2;
                System.Console.WriteLine("--------------------------------------------");
                System.Console.WriteLine("Hasil " +num1 + " x " + num2 + " = " + result);
                System.Console.WriteLine("--------------------------------------------");
                break;
                case "/" :
                result = num1 / num2;
                System.Console.WriteLine("--------------------------------------------");
                System.Console.WriteLine("Hasil " +num1 + " / " + num2 + " = " + result);
                System.Console.WriteLine("--------------------------------------------");
                break;
                case "^" :
                result = Math.Pow(num1 , num2);
                System.Console.WriteLine("--------------------------------------------");
                System.Console.WriteLine("Hasil " +num1 + " ^ " + num2 + " = " + result);
                System.Console.WriteLine("--------------------------------------------");
                break;
                default :
                System.Console.WriteLine();
                System.Console.WriteLine("Pilihan Tidak Tersedia!!");
                break;
            }
            string respon;
            do {
                System.Console.WriteLine("Apakah Anda ingin melakukan Perhitungan lagi ? (Iya/Tidak)");
                System.Console.Write("Ketik Disini....");
                switch(respon=Console.ReadLine().ToUpper()) {
                    case "IYA" :
                    coba_lagi = true;
                    break;
                    case "TIDAK" :
                    coba_lagi = false;
                    break;
                    default :
                    System.Console.WriteLine();
                    System.Console.WriteLine("Pilihan Tidak Tersedia!!");
                    break;
                } 

            }while (respon!="IYA" && respon!="TIDAK");

            }
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("Terima Kasih Telah Menggunakan Program ini...");
            System.Console.WriteLine("---------------------------------------------");
        }
    }
}
