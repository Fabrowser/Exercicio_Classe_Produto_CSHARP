using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClasseProduto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionaProduto(int q)
        {
            Quantidade = Quantidade + q;
        }
        
        public void RemoverProdutos(int q)
        {

            Quantidade = Quantidade - q;
        }

        public override string ToString()
        {
            return ($"Dados atualizados:\nNome: {Nome} \nPreço: {Preco} \nQuantidade:{Quantidade} \n" +
                $"Total: {ValorTotalEmEstoque().ToString("F2")}\n");
        }


    }
}
