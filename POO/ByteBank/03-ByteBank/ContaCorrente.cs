namespace _03_ByteBank
{
    internal class ContaCorrente
    {
        public string titular;
        public int NumeroAgencia;
        public int NumeroConta;
        public double saldo = 1000;

        public bool Sacar (double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }
    }
}