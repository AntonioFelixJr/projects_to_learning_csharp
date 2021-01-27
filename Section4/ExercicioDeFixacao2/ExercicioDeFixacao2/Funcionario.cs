using System.Globalization;

namespace ExercicioDeFixacao2
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return this.Salario - this.Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            this.Salario += this.Salario / porcentagem;
        }

        public override string ToString()
        {
            return $"{this.Nome}, $ {this.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}