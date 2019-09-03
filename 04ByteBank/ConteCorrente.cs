public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        return true;
    }

    //método sem retorno
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    //método com mais de um argumentos (parâmetros)
   public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        contaDestino.Depositar(valor);

        return true;
    }

}

