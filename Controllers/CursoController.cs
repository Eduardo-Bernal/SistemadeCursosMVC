using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDeCursoMVC.Data;
using SistemaDeCursoMVC.Models;

namespace SistemaDeCursoMVC.Controllers
{
    public class CursoController : Controller
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //Listar
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaCurso.ToListAsync();
            return View(lista);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(string NomeConstrutor, int horasConstrutor, string tipoCursoConstrutor)
        {
            Curso? novoCurso = null;
            if (tipoCursoConstrutor == "Tecnico")
            {
                novoCurso = new Tecnico(NomeConstrutor, horasConstrutor);
            }
            else if (tipoCursoConstrutor == "Superior")
            {
                novoCurso = new Superior(NomeConstrutor, horasConstrutor);
            }
            else
            {
                return BadRequest("Tipo de Curso Invalido!!");
            }

            _context.TabelaCurso.Add(novoCurso);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //Excluir
        public async Task<IActionResult> Deletar(int id)
        {
            var Curso = await _context.TabelaCurso.FindAsync(id);

            if (Curso == null) return NotFound(); // Registro não encontrado

            _context.TabelaCurso.Remove(Curso);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}