using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using houseasy_API.Domain.Models;

namespace houseasy_API.Application.Services.UsuarioService
{
    public interface IUsuarioInterface
    {
        Task<ServiceResponse<List<Usuario>>> GetUsuarios();
        Task<ServiceResponse<List<Usuario>>> CreateFuncionarios(Usuario modelCreate);
        Task<ServiceResponse<Usuario>> GetFuncionariosById(int id);
        Task<ServiceResponse<List<Usuario>>> UpdateFuncionarios(Usuario modelUpdate, int id);
        Task<ServiceResponse<List<Usuario>>> DeleteFuncionarios(int id);
    }
}