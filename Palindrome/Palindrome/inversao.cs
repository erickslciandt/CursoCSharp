﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class inversao
    {
        public static string mudaLetra( string palavra)
        {
            string resultado;
            int tam;
            resultado = "";
            tam = palavra.Length;

            for (int i = tam; i == 0; i--) {
                resultado = resultado + palavra[i];
            }
                

            return resultado;
        }
    }
}
