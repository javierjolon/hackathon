using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon
{
    class Scramble
    {
        public bool Validador(string palabra1, string palabra2)
        {
            List<string> listPalabra1 = new List<string>();
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            foreach (var item in palabra1)
            {
                string letra = item.ToString().ToLower();

                if (listPalabra1.Contains(letra))
                {
                    int cantidad = diccionario[letra];
                    cantidad++;
                    diccionario[letra] = cantidad;
                }
                else
                {
                    listPalabra1.Add(letra);
                    diccionario.Add(letra, 1);
                }
            }

            List<string> listPalabra2 = new List<string>();
            Dictionary<string, int> diccionario2 = new Dictionary<string, int>();

            foreach (var item in palabra2)
            {
                string letra = item.ToString().ToLower();

                if (listPalabra2.Contains(letra))
                {
                    int cantidad = diccionario2[letra];
                    cantidad++;
                    diccionario2[letra] = cantidad;
                }
                else
                {
                    listPalabra2.Add(letra);
                    diccionario2.Add(letra, 1);
                }
            }

            if (diccionario.Count != diccionario2.Count)
            {
                return false;
            }


            foreach (var item in listPalabra2)
            {
                if (listPalabra1.Contains(item))
                {
                    int cantidad1 = diccionario[item];
                    int cantidad2 = diccionario2[item];
                    if (cantidad1 != cantidad2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
