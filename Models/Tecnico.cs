namespace SistemaDeCursoMVC.Models
{
    public class Tecnico : Curso
    {
        //Metodo de Sobrecarda 
        public Tecnico() { }

        public Tecnico(String nomeConstrutor, int horasConstrutor) : base(nomeConstrutor, horasConstrutor)
        {

        }
        // Metodo de sobrescrita

        public override double CalcularPreco()
        {
            return Horas * 20;
        }

    }
}