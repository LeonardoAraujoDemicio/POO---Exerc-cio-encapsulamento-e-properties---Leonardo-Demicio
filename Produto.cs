using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercício_encapsulamento_Leo_A._Demicio
{
    public class Produto
    {
        public string Nome
        {
            get { return Nome; }

            set { if (value != null)
                {
                    Nome = value;
                }
            }
        }

        public double Preco
        {
            get {return Preco; }
        }

        public int Quantidade
        {
            get { return Quantidade; }
        }

        public Produto  (string nome, double preco, int quantidade)
        {
            nome = Nome;
            preco = Preco;
            quantidade = Quantidade;
        }

       
       
    }
}
