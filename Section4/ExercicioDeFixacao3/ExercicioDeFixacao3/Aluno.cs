using System;

namespace ExercicioDeFixacao3
{
    class Aluno
    {
        public string Nome;
        public float Nota1;
        public float Nota2;
        public float Nota3;
        private float MediaDeCorte = 60.0f;

        public float NotaFinal()
        {
            return this.Nota1 + this.Nota2 + this.Nota3;
        }

        public string Status()
        {
            return this.NotaFinal() >= this.MediaDeCorte ? "APROVADO" : "REPROVADO";
        }

        public float PontosFaltantes()
        {
            return Math.Abs(this.NotaFinal() - this.MediaDeCorte);
        }
    }
}