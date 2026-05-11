using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSI
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

        //=================================================== EXAMEN ==========================================================

        //Ejercicio 1

        //Seleccionar elementos repetidos en el rango [a,b] sin repetir en el resultado

        public void ejercicioX(int a, int b, ref Vector vr)
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

        public void insertar(int elemento)
        {
            n = n + 1; v[n] = elemento;

        }

        //Ejercicio 2

        public void Ejercicio2(int a, int b, ref Vector vr)
        {
            bool ban = true;
            vr.n = 0;

            int i1 = a - 1;
            int i2 = 0;
            int c1 = 0;
            int c2 = b - a + 1;

            // ordenar SOLO el rango
            OrdBurbujaRango(a, b);

            for (int i = a; i <= b; i++)
            {
                if (ban)
                {
                    c1++;
                    i1++;
                    vr.v[c1] = v[i1];
                    vr.n = c1;
                }
                else
                {
                    i2++;
                    i1++;
                    vr.v[c2] = v[i1];
                    c2--;
                }

                ban = !ban;
            }

            vr.n = b - a + 1;
        }

        public void OrdBurbujaRango(int a, int b)
        {
            for (int i = a; i < b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[i] > v[j])
                    {
                        Intercambio(i, j);
                    }
                }
            }
        }

        public void Intercambio(int a, int b)
        {
            int aux;

            aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }

    }
}
