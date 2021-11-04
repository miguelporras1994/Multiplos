using System;
using System.IO;

namespace mutiplode3
{
    class multiplo
    {

        
        public int[] uno;
        public StreamWriter escribir;

        public void leer()
        {
            uno = new int[3];
            StreamReader leer = new StreamReader("D:\\numeros.txt");



            int i = 0;




            while (!leer.EndOfStream)
            {

                uno[i] = Convert.ToInt32(leer.ReadLine());
                i++;
            }

            leer.Close();
        
         
            for(int f =1; f < 3; f++)
            {
                escribir = new StreamWriter("D:\\resultado.txt");
                if (uno[f] % 3 == 0)
                {
                    
                    escribir.WriteLine("Si");
                }
                else
                {


                    
                    escribir.WriteLine("No");
                }
                escribir.Close();
            }
        }

        static void Main(string[] args)
        {

            multiplo dos = new multiplo();
            dos.leer();

            Console.ReadKey();
        }
       
    }
}


