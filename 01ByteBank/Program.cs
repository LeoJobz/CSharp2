﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nossa primeira classe - Aula 1
namespace _01ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //instânciando a classe ContaCorrente
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número: "  + contaDaGabriela.numero);
            Console.WriteLine("Saldo: "   + contaDaGabriela.saldo);


            contaDaGabriela.saldo += 200;

            Console.WriteLine("Novo saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}