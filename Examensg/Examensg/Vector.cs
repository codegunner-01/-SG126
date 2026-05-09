using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensg
{
    class Vector
    {

        const int MAX = 50;
        private int[] v;
        private int n;



        public Vector()
        {
            n = 0;
            v = new int[MAX];

        }


        public void CargarRnd(int n1, int a, int b)
        {

            Random r = new Random();

            n = n1;

            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }




        public string Descargar()
        {
            string s = "";

            for (int i = 1; i <= n; i++)
            {

                s = s + v[i] + "  |  ";
            }

            return s;
        }

        //EXAMEN

    
        //Ejercicio 1
        

        public void Ejercicio1(int a, int b, ref Vector vr)
        {
            vr.n = 0;

            for (int i = a; i <= b; i++)
            {

                if (frecuencia_rango(v[i], a, b) > 1)
                {

                    if (!vr.Existe_ele(v[i]))
                    {
                        vr.insertar(v[i]);
                    }
                }
            }
        }
        public void insertar(int ele)
        {
            n = n + 1;
            v[n] = ele;

        }

        public int frecuencia_rango(int ele, int a, int b)
        {
            int cont = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                {
                    cont++;
                }
            }

            return cont;
        }

        public bool Existe_ele(int ele)
        {
            int i = 1;
            bool ban = false;

            while ((i <= n) && (ban == false))
            {
                if (v[i] == ele)
                {
                    ban = true;
                }
                else
                {
                    i = i + 1;
                }

            }

            return ban;
        }



        //Ejercicio 2
        public void Ejercicio2(int a, int b)
        {

            int k = b;
            bool ban = false;
            int p;

            for (int i = a; i <= k; i++)
            {

                p = Pos_Elem_Menor(i, k);

                if (ban == true)
                {
                   
                    intercambiar(p, i);
                }
                else
                {
                 
                    intercambiar(p, k);
                    k--;
                    i--;
                }

                ban = !ban; 

            }


        }

        public void intercambiar(int pos1, int pos2)
        {

            int aux;

            aux = v[pos1];
            v[pos1] = v[pos2];
            v[pos2] = aux;


        }

        public int Pos_Elem_Menor(int a, int b)
        {

            int men = v[a];
            int p = a;

            for (int i = a; i <= b; i++)
            {

                if (v[i] < men)
                {

                    men = v[i];
                    p = i;

                }
            }

            return p;
        }

    }
}
