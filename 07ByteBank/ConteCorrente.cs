

namespace _07ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }
        //caracteristicas compartilhada por todos os objetos gerados a apartir desse classe
        public static int TotalDeContasCriadas { get; private set; }       
        public int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                
                if (value < 0)
                {
                    return;
                }

                _saldo = value;

            }
        }        

        //construtor
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        //método sem retorno
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        //método com mais de um argumentos (parâmetros)
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);

            return true;
        }

    }
}


