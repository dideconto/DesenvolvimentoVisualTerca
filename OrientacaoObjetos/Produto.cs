using System;

namespace OrientacaoObjetos
{
    class Produto
    {
        private string nome;
        private int quantidade;
        private double preco;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

    }
}