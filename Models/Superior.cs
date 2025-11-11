namespace SistemaDeCursoMVC.Models
{
     public class Superior : Curso
    {
        //Metodo de Sobrecarda 
        public Superior() { }

        public Superior(String nomeConstrutor, int horasConstrutor) : base(nomeConstrutor, horasConstrutor)
        {

        }
        // Metodo de sobrescrita

        public override double CalcularPreco()
        {
            return Horas * 40;
        }

    }
}