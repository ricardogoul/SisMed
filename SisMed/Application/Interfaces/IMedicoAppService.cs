using SisMed.Application.ViewModels;

namespace SisMed.Application.Interfaces
{
    public interface IMedicoAppService
    {
        public IEnumerable<ListarMedicoViewModel> ListaMedico(string filtro);
    }
}
