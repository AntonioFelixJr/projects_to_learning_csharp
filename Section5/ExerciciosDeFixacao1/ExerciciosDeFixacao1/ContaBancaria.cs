using System.Globalization;


namespace ExerciciosDeFixacao1
{
    class ContaBancaria
    {
        private string _nomeTitular;
        public double Valor { get; private set; }
        public string Numero { get; private set; }

        public string NomeTitular
        {
            get { return this._nomeTitular; }
            set {
                if (value != null && value.Length > 2 )
                {
                    this._nomeTitular = value;
                }
            }
        }

        public ContaBancaria(string numero, string nome)
        {
            this.Numero = numero;
            this.NomeTitular = nome;
            this.Valor = 0.0;
        }
        public ContaBancaria(string numero, string nome, double depositoInicial) : this(numero, nome)
        {
            this.Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            this.Valor += valor;
        }
        public void Sacar(double valor)
        {
            this.Valor =  (this.Valor - 5.00) - valor;
        }

        public override string ToString()
        {
            return $"Conta {this.Numero}, Titular: {NomeTitular}, Saldo: $ {Valor.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
