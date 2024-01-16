﻿
namespace WebAPI_Funcionarios.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;

        public static implicit operator ServiceResponse<T>(ServiceResponse<List<FuncionarioModel>> v)
        {
            throw new NotImplementedException();
        }
    }
}
