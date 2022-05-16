

using System;


namespace Curso 
{
    class Triangulo {

        // Atributos
        public double A;
        public double B;
        public double C;

        //Métodos
        //Acesso ao método | Retorno do método (void caso não retorne) | Nome da função | (Parâmetros de entrada)
        public double Area() {
            
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C) );

            return raiz;
        }

    }
}