using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackSayfasıŞemaEfekt
{
    class Program
    {
        static void Main(string[] args)
        {

            //set test color

            Console.ForegroundColor = ConsoleColor.Green;

            //random number
            Random rand = new Random();


            //string pattern to print
            string str = "";


            Console.Write("Hackleniyorsunuz Canım.....");//Buraya İstediğinizi Yazabilirsiniz 
            Console.ReadKey();

            //loopto Display string pattern 
            //you can chance the no. of times to loop execute

            for (int i = 0; i < 200000; i++)
            {
                //create new string pattern
                if (i % 2 == 0)
                {
                    str = "";

                    for (int j = 0; j < 79; j++)
                    {
                        int n = rand.Next(5);
                        if (n < 2)
                        {
                            str += n.ToString();

                        }
                        else
                        {
                            str += " ";
                        }
                    }
                }
                //print str pattern 
                Console.WriteLine(str);

            }
            //enf of loop
            Console.WriteLine("Tolgahan Muhcı...");//Buraya İstediğinizi Yazabilirsiniz 
            Console.Write("Komador Tarafından Hacklendiniz .....");//Buraya İstediğinizi Yazabilirsiniz 
            Console.Read();



        }
    }
}
//En son Çalıştırmadan Önce Formu Build Bölümünden üstte solda Build Solution Ediyoruz Formu Çalıştırmak içinde Debug Bölümünden Üstte Solda Debug/Start WithhOut Debugging