using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Comportamento de Classes - Aula 3
namespace _03ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            //dois tipos: valor e referência
            //o resultado da comparação abaixo é false, pois cada variável está referenciando um objeto com endereços de memória diferentes
            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Comparação entre contas: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo Gabriela Costa: " + contaDaGabrielaCosta.saldo);
           
            Console.ReadLine();
        }
    }
}
