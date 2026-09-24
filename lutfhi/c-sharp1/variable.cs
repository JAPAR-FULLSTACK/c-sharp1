using System;
//using syestem digunakan untuk memanggil sebuah libary  yang ada di c# atau csharp gar bisa dia gunakan sebuah program
//syestem adalah libary yang berisi claas-class dasar yang digunakan dalam pemograman
namespace variable

//name space digunakan untuk menglompokan drbuah class class yang di dalam  program agar lebih mudah dalam  prngrlolahan nya
{

    
    class Program
    //claas program adalah claas utama  yang diguanakan dlama pemogaraman
    {
        
            static void Main(string [] args)
            //static adalah modifieryang digunakan untuk  mendklarasikan metdhod  atau property
            //yang dapat diakses tanpa harus membuat obbjeck dari class tersebut
            //void adalah tipe data yang digunakan untuk method yang tidak mengembalikan nilai
            //main adalah  method yaang digunakan  untuk  dalam sebuah program  ini
            //string [] args adlah parameter yang digunakan untuk menrima argumen dari command line


        {
            
            string nama = "MUHAMMAD RAFFADIAN PRATAMA";
            //string adlah tipe data yang digunakan untuk menyimpan sebuah data berupa teks atau karakter
            //nama adalah nama variable yang digunakan untuk menyimpan data berupa teks atua karakter
            int umur = 17;
            //int aladah tipe data yang di gunakan untuk menyimpan  data berupa teks atau karakter
            //umur adalah nama variable  yang digunakan untuk menerima data berupa data yang bulat
            double tinggibadan =180.5;
            //double adlah tipe data diguanakn untuk menyimpan berupa bilangan yang brrjumlah pecahan
            //tinggi badan adlah nama variable yang digunakan untuk menyimpan data berupa bilangan pecahan 
        
            char jeniskelamin = 'L';
            //char adalah tipe data yang dignakan untuk    menyimapan data berupa data yang tunggal 
            //jenis kelamin adlah  nama variable yang digunakan untuk meyimpan data berupa karakter tunggal
        
            float nilai   =90.15f;
            // float adlah tipe data yanag digunakan untuk menyimpan data berupa bilangan pecahan
            //nilai adalah nama variable yang digunakan untuk menyimpan data yang berupa bilangan pecahan

            bool statuslulus = true;
            //bool adalah tipe data uang mengunakan untuk menyimapan data berupa  nilai true dan false
            //status lulus adalah nama variable yang digunakan untuk menyimpan fata berupa nilai true

            decimal gaji =100.000m;
            //decimal adalah tipe uang digunakan untuk menyimpan data berupa bilangan pecahan presisi dengan tinggi
            //gaji adalah nama variable yang digunakan untuk data berupa bilangan pecahan dengan presisi tingii

            Console.WriteLine("==== DATA DIRI SAYA ===");
            //console.writeline adlah method yang digunakan untuk menampilkan output ke layar
            Console.WriteLine("Nama          :" + nama);
            //wriiteline adalah method uang digunakan untuk menampilkan output ke layar dan menambahkan baris baru setelahnya
            // + adalah operator yang digunakan untuk mengabungkan sring dengan variable
            //nama adalah variable yang digunakan untuk menyimpan data berupa teks atau berkarakter
            Console.WriteLine("Umur          :" + umur + "TAHUN");
            //umur adalah variable yang digunakan untuk menyimpan data berupa bilangan bulat
            // tahun adalah teks yang ditambahkan untuk menampilkan satuan umur
            //writeline adalah method yang digunakan untuk menampilkan ouput ke layar dan ,ema,bahlam baris baru setelahnya
            //+ adalah operator yang digunakan untuk menggabungkan string denag variable
            Console.WriteLine("Tinggi Badan  :"+ tinggibadan + "CM");
            //tinggi badan adalah variable yang digunakn untuk menyimpan data berupa bilangaa pecahan 
            //writeline adalah method yang digunakan untuk menampilkan ke output ke layar dan menambahkana baris setelahnya
            // + adalh operator yang digunakn untuk menggabungkan string dengan variable
            Console.WriteLine("NILAI         :"+ nilai);
            // nilai adalah variabel yang digunakan untuk menyimpan data berupa bilangan pecahan.
            //writeline adalah method yang digunakn untuk menampilkan output ke layar dan menambahkan bari baru setelahnya
            //+ adalah operator yang digunakan untuk menggabungkan string dan variable
            Console.WriteLine("Jenis Kelamin :" + jeniskelamin);
            // jenisKelamin adalah variabel yang digunakan untuk menyimpan data berupa karakter tunggal.
            // WriteLine adalah method yang digunakan untuk menampilkan output ke layar dan menambahkan baris baru setelahnya.
            // + adalah operator yang digunakan untuk menggabungkan string dengan variabel.
            Console.WriteLine("Status Lulus  :"+ statuslulus);
            // statusLulus adalah variabel yang digunakan untuk menyimpan data berupa nilai true atau false.
            // WriteLine adalah method yang digunakan untuk menampilkan output ke layar dan menambahkan baris baru setelahnya.
            // + adalah operator yang digunakan untuk menggabungkan string dengan variabel.
            Console.WriteLine("Gaji          : Rp" + gaji);
            // gaji adalah variabel yang digunakan untuk menyimpan data berupa bilangan pecahan dengan presisi tinggi.
            // WriteLine adalah method yang digunakan untuk menampilkan output ke layar dan menambahkan baris baru setelahnya.
            // + adalah operator yang digunakan untuk menggabungkan string dengan variabel.
            Console.ReadKey("");
            // Console.ReadKey adalah method yang digunakan untuk menunggu input dari keyboard sebelum menutup program.

        }


    }
}