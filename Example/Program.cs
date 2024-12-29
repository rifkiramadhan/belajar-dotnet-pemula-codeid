using System.Data;

internal class Program
{
    private static void Main1(string[] args)
    {
        // 1. Console
        //Console.WriteLine("Hello, World!");

        // 2. Variable dan Tipe Data
        //int A = 5;
        //int B = A + 5;
        //Console.WriteLine(B);

        //char inisial = 'A';
        //Console.WriteLine(inisial);

        //string firstName = "Rifki";
        //string lastName = "Ramadhan";
        //string fullName = $"{firstName} {lastName}";
        //Console.WriteLine(fullName);

        //bool kondisi = true;
        //Console.WriteLine(kondisi);

        // 3. Mengambil input dari user
        //string nama;
        //Console.WriteLine("Siapa Namamu: ");
        //nama = Console.ReadLine();

        //Console.WriteLine("Namamu Adalah: " + nama);

        // 4. Convert Class => Mengubah tipe data ke tipe lainnya
        //int a;
        //Console.WriteLine("Masukkan Angka: ");
        //a = Convert.ToInt16(Console.ReadLine());

        //Console.WriteLine("Angka Anda Adalah: " + a);

        //int b;
        //Console.WriteLine("Masukkan Nilai B: ");
        //b = Convert.ToInt16(Console.ReadLine());

        //string x = Convert.ToString(a + b);

        //Console.WriteLine("Hasilnya Adalah: " + x);

        // 5. Operator Aritmatika
        /*
         1. Penjumlahan: +
         2. Pengurangan: -
         3. Perkalian: *
         4. Pembagian: /
         5. Modulus/sisa bagi: %
         */

        //int a;
        //int b;
        //Console.WriteLine("Masukkan Angka ke-1:");
        //a = Convert.ToInt16(Console.ReadLine());

        //Console.WriteLine("Masukkan Angka ke-2: ");
        //b = Convert.ToInt16(Console.ReadLine());

        //double aDbl = Convert.ToDouble(a);
        //double bDbl = Convert.ToDouble(b);

        //Console.WriteLine("\n----------------------------------------\n");

        //Console.WriteLine($"Hasil dari penjumlahan nilai {a} + {b} adalah: " + Convert.ToInt16(a + b));
        //Console.WriteLine($"Hasil dari pengurangan nilai {a} - {b} adalah: " + Convert.ToInt16(a - b));
        //Console.WriteLine($"Hasil dari perkalian nilai {a} * {b} adalah: " + Convert.ToInt16(a * b));
        //Console.WriteLine($"Hasil dari pembagian nilai {a} / {b} adalah: " + Convert.ToDouble(aDbl / bDbl));
        //Console.WriteLine($"Hasil dari sisa bagi nilai {a} % {b} adalah: " + Convert.ToInt16(a % b));

        // 6. Struktur Percabangan
        /*
         1. if
         2. if else
         3. if else, else if
         4. if else, else if, else
         */

        // Case 1

        //string nama = "Romsea";
        //if (nama == "Rifki")
        //{
        //    Console.WriteLine("Hello, Nama Saya Adalah: " + nama);
        //}
        //else if (nama == "Romsea")
        //{
        //    Console.WriteLine("Hello, Namamu Belum Aktif!");
        //}
        //else
        //{
        //    Console.WriteLine("Hello, Apakah Anda Sudah Mendaftar?");
        //}

        // Case 2

        //string nama;
        //Console.WriteLine("Masukkan Nama: ");
        //nama = Console.ReadLine();

        //if (nama == "Rifki" || nama == "rifki")
        //{
        //    Console.WriteLine("Hello, Nama Saya Adalah: " + nama);
        //}
        //else if (nama == "Romsea" || nama == "romsea")
        //{
        //    Console.WriteLine("Hello, Namamu Belum Aktif!");
        //}
        //else
        //{
        //    Console.WriteLine("Hello, Apakah Anda Sudah Mendaftar?");
        //}

        // 7. Konsep if else Bersarang

        //string username;
        //string password;

        //Console.Write("Masukkan Username: ");
        //username = Console.ReadLine();

        //if (username == "admin" || username == "user")
        //{
        //    Console.Write("Masukkan Password: ");
        //    password = Console.ReadLine();

        //    if (password == "admin" || username == "user")
        //    {
        //        Console.WriteLine($"Hello, Selamat Datang {username}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Username Atau Password Anda Salah!");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Username Anda Tidak Ditemukan!");
        //}

        // 8. Switch Statement

        //int jurusan;
        //Console.WriteLine("Pilih Jurusan:");
        //Console.WriteLine("1. RPL");
        //Console.WriteLine("2. TKJ");
        //Console.WriteLine("3. Multimedia");

        //jurusan = Convert.ToInt32(Console.ReadLine());

        //switch (jurusan)
        //{
        //    case 1:
        //        Console.WriteLine("Pelajarannya Adalah Pemrograman");
        //        break;
        //    case 2:
        //        Console.WriteLine("Pelajarannya Adalah Komputer dan Jaringan");
        //        break;
        //    case 3:
        //        Console.WriteLine("Pelajarannya Adalah Desain Grafis");
        //        break;
        //    default:
        //        Console.WriteLine("Pelajaran Tidak Tersedia!");
        //        break;
        //}

        // 9. Array

        // Case 1
        //int[] nilai = { 10, 20, 30 };
        //Console.WriteLine(nilai[0]);

        // Case 2
        //int[] nilai = new int[3];
        //nilai[0] = 10;
        //nilai[1] = 20;
        //nilai[2] = 30;

        //Console.WriteLine(nilai[2]);

        // Case 3
        //string[] pemeliharaan = new string[4];
        //pemeliharaan[0] = "Ayam";
        //pemeliharaan[1] = "Kelinci";
        //pemeliharaan[2] = "Kucing";
        //pemeliharaan[3] = "Landak";

        //Console.WriteLine(pemeliharaan[3]);

        // 10. Looping for

        // Case 1

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"{i}. Junior Fullstack Developer");
        //}

        // Case 2

        //int[] nilai = new int[5];
        //nilai[0] = 50;
        //nilai[1] = 40;
        //nilai[2] = 30;
        //nilai[3] = 83;
        //nilai[4] = 77;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine(nilai[i]);
        //}

        // Case 3
        //int ukuranArray = 3;
        //string[] jurusan = new string[ukuranArray];
        //jurusan[0] = "RPL";
        //jurusan[1] = "Multimedia";
        //jurusan[2] = "TKJ";

        //for (int i = 0; i < ukuranArray; i++)
        //{
        //    Console.WriteLine(jurusan[i]);
        //}

        // 11. Program Sederhana for & array

        // Case 1
        //int jumlahArray;
        //Console.WriteLine("Masukkan Jumlah Array:");
        //jumlahArray = Convert.ToInt32(Console.ReadLine());

        //int[] nilai = new int[jumlahArray];
        //for (int i = 0; i < jumlahArray; i++)
        //{
        //    Console.WriteLine($"Nilai Array ke-{i}:");
        //    nilai[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //for(int i = 0; i < jumlahArray; i++)
        //{
        //    Console.WriteLine($"Nilai Array ke-{i} adalah {nilai[i]}");
        //}

        // Case 2
        //int jumlahArray;
        //Console.WriteLine("Masukkan Jumlah Array:");
        //jumlahArray = Convert.ToInt32(Console.ReadLine());

        //string[] nama = new string[jumlahArray];
        //for(int i = 0; i < jumlahArray; i++)
        //{
        //    Console.WriteLine("Masukkan Nama Siswa:");
        //    nama[i] = Console.ReadLine();
        //}

        //for (int i = 0; i < jumlahArray; i++)
        //{
        //    Console.WriteLine($"Nama Siswa ke-{i} Adalah {nama[i]}");
        //}

        // 12. foreach
        //string[] siswa = { "siswa1", "siswa2", "siswa3", "siswa4", "siswa5", "siswa6" };

        //foreach (var nama in siswa)
        //{
        //    Console.WriteLine(nama);
        //}

        //Console.WriteLine("==========");

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine(siswa[i]);
        //}

        // 13. While & do While

        // Case 1
        //int a = 0;
        //while (a < 5)
        //{
        //    Console.WriteLine("Junior Fullstack!");
        //    a++;
        //}

        // Case 2
        //int a = 0;
        //do
        //{
        //    Console.WriteLine("Junior Fullstack!");
        //    a++;
        //}
        //while (a < 5);

        // Case 3
        //string username = "";
        //while (username != "admin")
        //{
        //    Console.Write("username: ");
        //    username = Console.ReadLine();

        //    if (username != "admin")
        //    {
        //        Console.WriteLine("username tidak ada!");
        //    }
        //}

        // 14. Operator Logika
        /*
         1. AND = &&
         2. OR = |||
         3. NOT = |
         */

        // Case 1
        //string name = "hafiz";
        //int umur = 16;

        //if (name == "hafiz" || umur == 16)
        //{
        //    if (umur == 16)
        //    {
        //        Console.WriteLine("Hello World!");
        //    }
        //}

        // Case 2
        //bool hidup = false;
        //if (!hidup)
        //{
        //    Console.WriteLine("Padam!");
        //}

        // 15. Operator Perbandingan

        /*
         Operator perbandingan:
         1. ==
         2. !=
         3. <=
         4. >=
         5. <
         6. >
         */

        //if (5 < 10)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}

        // 16. Void Method Function
        //tampilkan();
        //tambah(20, 5);
        //kuadrat(3);
        //pembagian(49, 8);
        //Login();

        // Case 1
        //void tampilkan()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Halo Semuanya!");
        //    }
        //}

        // 17. Fungsi Return

        // Case 1
        //int tambah(int a, int b)
        //{
        //    return a + b;
        //}

        //int kurang(int a, int b)
        //{
        //    return a - b;
        //}

        ////int hasilTambah = tambah(5, 5) + 10; // 20
        //int hasilKurang = tambah(kurang(15, 5), 5) + 10;
        //Console.WriteLine(hasilKurang);

        // Case 2
        //bool ApakahLulus(int nilai)
        //{
        //    if (nilai < 78)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //Console.Write("Masukkan Nilai: ");
        //int _nilai = Convert.ToInt32(Console.ReadLine());

        //if (ApakahLulus(_nilai))
        //{
        //    Console.WriteLine("Selamat, Anda Lulus");
        //}
        //else
        //{
        //    Console.WriteLine("Maaf, Anda Tidak Lulus!");
        //}

        // Case 3
        //int tambah(int a, int b)
        //{
        //    return a + b;
        //}

        //int hasil = tambah(5, 5);
        //Console.WriteLine(hasil);

        // 18. Fungsi Overloading
        //tambah(5, 9.5);
        //tambah(2.5, 5.3);
        //tampilkan(80);

        // 19. Casting
        //double a = 2.5;
        //int b = 2;
        //int hasil = (int)a + b;

        //Console.WriteLine(hasil);
    }


    // 16. Void Method Function

    // Case 2
    //static void tampilkan()
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        Console.WriteLine("Halo Semuanya!");
    //    }
    //}

    // Case 3
    //static void tambah(int a, int b)
    //{
    //    Console.WriteLine(a + b);
    //}

    // Case 4
    //static void kuadrat(int a)
    //{
    //    Console.WriteLine($"Kuadrat dari {a} adalah: {a}");
    //}

    // Case 5
    //static void pembagian(double a, double b)
    //{
    //    Console.WriteLine($"{a} dibagi {b} adalah: {a/b}");
    //}

    // Case 6
    //static void Login()
    //{
    //    string username = "";
    //    string password = "";

    //    while (username != "admin" && password != "admin")
    //    {
    //        Console.Write("Username: ");
    //        username = Console.ReadLine();

    //        Console.Write("Password: ");
    //        password = Console.ReadLine();

    //        if (username == "admin" && password == "admin")
    //        {
    //            Console.WriteLine("Selamat datang admin!");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Username atau password salah!");
    //        }
    //    }
    //}

    // 18. Fungsi Overloading

    // Case 1
    //static void tambah(int a, int b)
    //{
    //    Console.WriteLine(a + b);
    //    Console.WriteLine("Fungsi 1");
    //}

    //static void tambah(double a, double b)
    //{
    //    Console.WriteLine(a + b);
    //    Console.WriteLine("Fungsi 2");
    //}

    // Case 2
    //static void tampilkan(int a)
    //{
    //    Console.WriteLine(a);
    //}

    //static void tampilkan(string a)
    //{
    //    Console.WriteLine(a);
    //}

    //static void tampilkan(double a)
    //{
    //    Console.WriteLine(a);
    //}

    //static void tampilkan(char a)
    //{
    //    Console.WriteLine(a);
    //}
}