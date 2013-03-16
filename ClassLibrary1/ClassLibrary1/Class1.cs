using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public int convertir(string romano)
        {
            var vecRomano = romano.ToCharArray();
            int contador = 0;
            char primero = vecRomano[0];
            int ant = 0;
            for (int i = 0; i <= (vecRomano.Length - 1); i++)
            {
                if (this.controlarMayor(vecRomano[i], vecRomano[ant]))
                {
                    contador = contador + this.dameTuValor(vecRomano[i]);
                }
                else
                {
                    contador = this.dameTuValor(vecRomano[i]) - contador;
                }

                if (i != 0)
                    ant++;
            }

            return contador;

        }

        private bool controlarMayor(char pos, char ant)
        {
            return this.dameTuValor(pos) <= this.dameTuValor(ant);
        }

        private int dameTuValor(char pos)
        {
            if (pos.Equals('I'))
                return 1;

            if (pos.Equals('V'))
                return 5;

            if (pos.Equals('X'))
                return 10;

            if (pos.Equals('L'))
                return 50;

            if (pos.Equals('C'))
                return 100;

            if (pos.Equals('D'))
                return 500;

            if (pos.Equals('M'))
                return 1000;
            return 0;
        }
        public bool validar(string h)
        {
            var vecCaract = h.ToCharArray();
            Stack<char> pilaAbierta = new Stack<char>();
            for (int i = 0; i <= (vecCaract.Length - 1); i++)
            {
                if (abre(vecCaract[i]))
                {
                    pilaAbierta.Push(vecCaract[i]);
                }

                if (cierra(vecCaract[i]))
                    if (!(this.comparar(pilaAbierta.Pop, vecCaract[i])))
                    {
                        return false;
                    }

            }
            return true;
        }

        private bool cierra(char p)
        {
            return p.Equals(']') || p.Equals(')') || p.Equals('}');

        }



        private bool abre(char p)
        {
            return p.Equals('{') || p.Equals('(') || p.Equals('[');
        }

    }
}
