/*
 * nama : Kevin Resha Valeryan Andana(16)
 *        Maise Ivenna Larisa(17)
 *        
 */



using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace KalkulatorAbsen16_17;

class Program
{
    static void Main(string[] args)
    {
        string value;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" Kalkulator Sederhana Ide absen 16 & 17");
        Console.WriteLine(" Kalkulator ini mengambil refrensi dari Google,Youtube,Dan Pembelajaran");
        Console.WriteLine(" Jadi bila ada kekurangan Mohon Maaf");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Cara penggunaan:");
        Console.WriteLine("Silahkan Angka pertama dimasukkan lalu, enter");
        Console.WriteLine("Silahkan masukkan Operator yang anda inginkan lalu, enter");
        Console.WriteLine("Silahkan masukkan angka kedua lalu,silahkan ketik enter");
        Console.WriteLine("Jika anda ingin mengulang kembali ketik enter setelah Hasil muncul");
        Console.WriteLine("Setelah enter, jika anda ingin lanjut lagi, silahkan ketik (L) ");
        Console.WriteLine("Setelah enter, jika anda ingin berhenti silahkan Ketik (B)");
        Console.WriteLine();
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("List Operator Perhitungan: ");
        Console.WriteLine(" +  Untuk Penjumlahan");
        Console.WriteLine(" x  Untuk Perkalian");
        Console.WriteLine(" -  Untuk Pengurangan");
        Console.WriteLine(" %  Untuk Sisa hasil bagi");
        Console.WriteLine(" /  Untuk Pembagian");
        Console.WriteLine(" ^  Untuk Pangkat");
        Console.WriteLine();
        Console.ResetColor();
        do
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Silahkan masukkan angka yang ingin dimasukkan : ");
            Console.ResetColor();
            int hasil_16_17;
            Console.Write("Massukan Angka Pertama=");
            int x_16_17 = int.Parse(Console.ReadLine());
            Console.Write("Pilih Symbol berikut ini =");
            string symbol = Console.ReadLine();
            Console.Write("Masukkan Angka Kedua=");
            int y_16_17 = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                case "+":
                    hasil_16_17 = x_16_17 + y_16_17;
                    Console.WriteLine(" Hasil Dari " + x_16_17 + "+" + y_16_17 + "=" + hasil_16_17);
                    break;
                case "-":
                    hasil_16_17 = x_16_17 - y_16_17;
                    Console.WriteLine("Hasil dari " + x_16_17 + "-" + y_16_17 + "=" + hasil_16_17);
                    break;
                case "x":
                    hasil_16_17 = x_16_17 * y_16_17;
                    Console.WriteLine("Hasil dari " + x_16_17 + "x" + y_16_17 + "=" + hasil_16_17);
                    break;
                case "/":
                    hasil_16_17 = x_16_17 / y_16_17;
                    Console.WriteLine("Hasil dari " + x_16_17 + "/" + y_16_17 + "=" + hasil_16_17);
                    break;
                case "%":
                    hasil_16_17 = x_16_17 % y_16_17;
                    Console.WriteLine("Hasil dari " + x_16_17 + "%" + y_16_17 + "=" + hasil_16_17);
                    break;
                case "^":
                    hasil_16_17 = Pangkat_16_17(x_16_17, y_16_17);
                    Console.WriteLine("Hasil Dari " + x_16_17 + "^" + y_16_17 + "=" + hasil_16_17);
                    break;

                default:
                    Console.WriteLine("");
                    break;

            }
            Console.WriteLine("Ketik N untuk Mengakhiri dan Y untuk melanjutkan (Y/N)");
            value = Console.ReadLine();
        } while (value == "Y" || value == "Y");


    }

    static int Pangkat_16_17(int x, int y)
    {
        int hasil = x;
        if (y > 0)
        {
            for (int j = 0; j < y - 1; j++)
            {
                hasil *= x;
            }

        }
        else
        {
            y *= -1;
            hasil = 1 / x;
            for (int j = 0; j > y + 1; j--)
            {
                hasil *= x;
            }
        }
        return hasil;
    }
}