using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making_with_different_method
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class Inputdata untuk mengimput data</remarks>
    class Inputdata
    {
        // method yang berfungsi untuk memasukkan data
        public double nilM, nilB;
        
        

        public void Masukkandata()
        {
            /// <example> memasukkan nilai </example>
            // Display 'Masukkan Nilai Matematika ='
            Console.Write("Masukkan Nilai Matematika= ");

            // Accept nilM
            nilM = Convert.ToDouble(Console.ReadLine());

            // Display 'Masukkan Nilai Bahasa Inggris = '
            Console.Write("Masukkan Nilai Bahasa Inggris= ");

            // Accept nilB
            nilB = Convert.ToDouble(Console.ReadLine());
        }
    }

    class prosesdata
    {
        // method yang berfungsi untuk memproses data
        public double rerata;
        public string status;

        public void Prosesdata(double nilM, double nilB)
        {
          
            // Compute rerata = (nilM + nilB) / 2
            rerata = (nilM + nilB) / 2;
            
        }
      
        public void gantistatus(double nilM)
        {
            Inputdata id = new Inputdata();

            // if (rerata >= 60 AND nilM >= 70)
            if (rerata >= 60 && nilM >= 70)            
            { // Begin
                  
                // status = 'lulus'
                status = "lulus";
            } // End

            // Else
            else
            { //Begin

                //status = 'gagal'
                status = "gagal";
            } // End

        }
    }

    class Outputdata
    {
        
        // method yang berfungsi untuk menampilkan output data
          
        public void tampilindata(string status)
        {
          

            // Display 'Status peserta adalah ' + status
            Console.WriteLine("Status peserta adalah {0}", status);
            Console.ReadKey();
        }
    }
        
    

    class Program
    {
        static void Main(string[] args)
        {
            //initiate class (membuat objek baru untuk kelas)
            Inputdata id = new Inputdata();
            prosesdata pd = new prosesdata();
            Outputdata od = new Outputdata();
            

            //panggil method untuk input data
            id.Masukkandata();

            //panggil method untuk proses data
            pd.Prosesdata(id.nilB, id.nilM);
            pd.gantistatus(id.nilM);

            //panggil method untuk output data
            od.tampilindata(pd.status);
            
        }
    }
}
