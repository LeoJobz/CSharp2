using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nossa primeira função - Aula 03
namespace _04ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo Anterior: " + contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine("Saldo Atual: " + contaDoBruno.saldo);


            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo após depósito:" + contaDoBruno.saldo);

            
            //conta de destino
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo Bruno antes da transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela antes da transferência: " + contaDaGabriela.saldo);


            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo Bruno após transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela após transferência: " + contaDaGabriela.saldo);

            Console.WriteLine("Retorno transferência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo Bruno após transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela após transferência: " + contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
