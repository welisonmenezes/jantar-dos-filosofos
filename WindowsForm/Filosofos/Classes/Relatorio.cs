using System;
using System.Collections.Generic;

namespace Filosofos.Classes
{
    public class Relatorio
    {
        public Dictionary<string, long> relatorios = new Dictionary<string, long>();
        Action method;

        public Relatorio(Action method)
        {
            this.method = method;
        }

        public void adicionaRelatorio(string key, int value)
        {
            this.relatorios.Add(key, value);
        }

        public long pegaValorDoRelatorio(string key)
        {
            long value;
            if (this.relatorios.TryGetValue(key, out value))
            {
                return value;
            }
            return 0;
        }

        public void incrementaRelatorio(string Name)
        {
            long value = this.pegaValorDoRelatorio(Name);
            value += 1;
            this.relatorios[Name] = value;
            this.method();
        }


        public void atualizaRelatorio(string Name, long valor)
        {
            this.relatorios[Name] = valor;
            this.method();
        }

    }
}
