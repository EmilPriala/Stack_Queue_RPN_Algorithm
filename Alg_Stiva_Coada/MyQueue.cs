using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Stiva_Coada
{

    public class MyQueue: TADL
    {
        public MyQueue(): base() { }

        public override float Pop()
        {
            float[] temp = new float[values.Length - 1];
            float toR = values[values.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = values[i];
            }
            values = temp;
            return toR;
        }
        
    }


    /* varianta initiala
    public class Coada
    {
        int[] values;

        public Coada()
        {
            values = new int[0];
        }
        public void Push(int value)
        {
            int[] temp = new int[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                temp[i + 1] = values[i];
            }
            temp[0] = value;
            values = temp;
        }
        public void Pop() 
        {
            int[] temp = new int [values.Length - 1];
            int toR = values[values.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = values[i];
            }
        }
        public override string ToString()
        {
            return View();
        }
        public virtual string View()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                sb.Append(values[i]);
                sb.Append(", ");
            }
            return sb.ToString();
        }

    }*/
}
