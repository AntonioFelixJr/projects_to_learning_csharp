

namespace MediaSalarioDeDoisFuncionarios
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public double MediaEntreDoisSalarios(double salario1, double salario2)
        {
            return (salario1 + salario2) / 2.0;
        }
    }
}
