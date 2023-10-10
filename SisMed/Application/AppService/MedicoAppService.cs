using SisMed.Application.Interfaces;
using SisMed.Application.ViewModels;
using SisMed.Data.Contexts;
using SisMed.Models.Entities;

namespace SisMed.Application.AppService
{
    public class MedicoAppService : IMedicoAppService
    {
        private readonly SisMedContext _context;
        public MedicoAppService(SisMedContext context)
        {
            _context = context;
        }

        public IEnumerable<ListarMedicoViewModel> ListaMedico(string filtro = "")
        {
            IQueryable<Medico> query = _context.Medicos;

            if (!string.IsNullOrEmpty(filtro))
            {
                query = query.Where(x => x.Nome.Contains(filtro) || x.CRM.Contains(filtro));
            }

            var vm = query.Select(x => new ListarMedicoViewModel
            {
                Id = x.Id,
                CRM = x.CRM,
                Nome = x.Nome,
            }).ToList();

            return vm;
        }
    }
}
