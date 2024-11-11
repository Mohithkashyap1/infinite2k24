using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenClass
{   

    class GenFunc<T>
    {

        public void Display<T>(string msg, T value)
        {

            Console.WriteLine("{0}:{1}",msg,value);

        }

    }


    internal class GenFunc
    {

        public static void Main(string[] args)
        {

            GenFunc<string> gf = new GenFunc<string>();

            gf.Display<int>("I am Batman", 947);

            gf.Display<string>("I am Bond", "James Bond");



        }




    }
}
