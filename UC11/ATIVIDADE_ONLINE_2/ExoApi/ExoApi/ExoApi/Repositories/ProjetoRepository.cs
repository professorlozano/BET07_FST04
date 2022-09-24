using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly dbExoAPIContext _context;

        public ProjetoRepository(dbExoAPIContext context)
        {
            _context = context;
        } 
        
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
    }
}
