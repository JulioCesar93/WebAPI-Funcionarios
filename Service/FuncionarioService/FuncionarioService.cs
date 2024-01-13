using WebAPI_Funcionarios.Models;

namespace WebAPI_Funcionarios.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        public Task<ServerResponse<List<FuncionarioModel>>> GetFuncionarios()
        {
            throw new NotImplementedException();
        }
    }
}

