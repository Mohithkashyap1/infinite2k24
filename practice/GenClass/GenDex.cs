using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenClass
{

    class gendex1<T>
    {

        T[] data = new T[10];

        T war;

        public T var
        {
            get { return war; }

            set { war = value; }
        }


        public T this[int index]
        {

            get { return data[index]; }

            set { data[index] = value; }
        }

        public T this[float index]
        {

            get { return data[(int)index]; }

            set { data[(int)index] = value; }

        }


    }

    internal class GenDex
    {
        gendex1<float> gd1 = new gendex1<float>();

        gd1[0]=5.5f;




    }
}
