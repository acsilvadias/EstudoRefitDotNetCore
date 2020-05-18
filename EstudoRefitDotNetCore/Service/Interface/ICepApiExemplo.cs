using EstudoRefitDotNetCore.RefitExemplo;
using Refit;
using System.Threading.Tasks;


namespace EstudoRefitDotNetCore.Service.Interface
{
    public interface ICepApiExemplo
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsynnc(string cep);
    }
}
