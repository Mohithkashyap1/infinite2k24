using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenClass
{

    class GenKins<T>
    {

        private T Gk;
        public GenKins(T obj)
        {
            this.Gk = obj;


        }

        //Generic Method


        public T GenMeth<T>(T obj)
        {

            Console.WriteLine("Parameter type : {0} & {1}", typeof(T).ToString(),obj);

            Console.WriteLine("Returntype : {0} & {1}",typeof(T).ToString(),obj);

            return obj;

        }



    }

    internal class Gencons
    {

        public static void Main(string[] args)
        {
            GenKins<Object> jk = new GenKins<Object>(123456789);

            Console.WriteLine(jk.GenMeth("Hello Brother"));





        }





    }
}
