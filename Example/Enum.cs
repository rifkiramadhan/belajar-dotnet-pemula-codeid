using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Enum
    {
        enum Hari
        {
            senin = 1,
            selasa,
            rabu,
            kamis,
            jumat,
            sabtu,
            minggu,
        }

        static void Main()
        {
            Hari sekarang;
            Console.Write("Masukkan Nomor Hari (ex: 1-7): ");
            sekarang = (Hari)Convert.ToInt32(Console.ReadLine());
            
            tampilkanHari(sekarang);
            Console.ReadKey();

            void tampilkanHari(Hari _sekarang)
            {
                int i = (int)_sekarang;
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Senin");
                        break;
                    case 2:
                        Console.WriteLine("Selasa");
                        break;
                    case 3:
                        Console.WriteLine("Rabu");
                        break;
                    case 4:
                        Console.WriteLine("Kamis");
                        break;
                    case 5:
                        Console.WriteLine("Jumat");
                        break;
                    case 6:
                        Console.WriteLine("Sabtu");
                        break;
                    case 7:
                        Console.WriteLine("Minggu");
                        break;
                    default:
                        Console.WriteLine("Hari tidak tersedia!");
                        break;

                }    
            }
        }
    }
}
