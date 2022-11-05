using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    class Class1
    {
        public void Justificar(string palabra, int cantidad)
        {
            string[] listado = palabra.Split(" ");
            List<string> fila = new List<string>();

            for (int i = 0; i < listado.Length; i++)
            {
                string palabraTemp = listado[i];

                if (palabraTemp.Length < cantidad)
                {
                    if (fila.Count == 0)
                    {
                        char[] ftemp = palabraTemp.ToCharArray();
                        foreach (var item in ftemp)
                        {
                            fila.Add(item.ToString());
                        }
                        fila.Add(" ");
                    }
                    else
                    {
                        if (fila.Count < cantidad)
                        {
                            char[] ftemp = palabraTemp.ToCharArray();
                            foreach (var item in ftemp)
                            {
                                fila.Add(item.ToString());
                            }
                            fila.Add(" ");
                        }
                        else
                        {
                            Espacios(fila, cantidad);
                        }
                    }
                }
            }

        }

        private void Espacios(List<string> fila, int cantidad)
        {
            int cantidadDeCaracteres = 0;
            foreach (var item in fila)
            {
                cantidadDeCaracteres += item.Length;
            }


            if (cantidadDeCaracteres < cantidad)
            {
                for (int i = 0; i < fila.Count; i++)
                {

                }
            }

        }
    }
}
