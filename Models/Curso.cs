using Microsoft.Net.Http.Headers;

namespace SistemaDeCursoMVC.Models
{
    public abstract class Curso
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int Horas { get; set; }

        public Curso() { }
        public Curso(String nomeConstrutor, int horasConstrutor)
        {
            Nome = nomeConstrutor;
            Horas = horasConstrutor;
        }

        public abstract double CalcularPreco();


    }
}