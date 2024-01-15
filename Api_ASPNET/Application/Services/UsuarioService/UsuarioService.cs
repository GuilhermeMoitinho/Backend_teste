using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using houseasy_API.Domain.Models;
using houseasy_API.Infrastructure.DataContext;

namespace houseasy_API.Application.Services.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Usuario>>> CreateFuncionarios(Usuario modelCreate)
        {
            var ServiceResponse = new ServiceResponse<List<Usuario>>();

            try
            {
                if (modelCreate == null)
                {
                    ServiceResponse.Dados = null;
                    ServiceResponse.Mensagem = "Informar Usuário!";

                    return ServiceResponse;
                }

                _context.Usuarios.Add(modelCreate);
                await _context.SaveChangesAsync();

                ServiceResponse.Dados = _context.Usuarios.ToList();
                ServiceResponse.Mensagem = "Usuário criado com sucesso!";


            }
            catch (Exception x)
            {
                ServiceResponse.Mensagem = x.Message;
            }

            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Usuario>>> DeleteFuncionarios(int id)
        {
            var ServiceResponse = new ServiceResponse<List<Usuario>>();

            try
            {
                if (id == null)
                {
                    ServiceResponse.Dados = null;
                    ServiceResponse.Mensagem = "Usuário não identificado!";

                    return ServiceResponse;
                }

                var UsuarioRemover = _context.Usuarios.Find(id);

                _context.Usuarios.Remove(UsuarioRemover);
                await _context.SaveChangesAsync();

                ServiceResponse.Dados = _context.Usuarios.ToList();
                ServiceResponse.Mensagem = "Usuário removido com sucesso!";


            }
            catch (Exception x)
            {
                ServiceResponse.Mensagem = x.Message;
            }

            return ServiceResponse;
        }

        public async Task<ServiceResponse<Usuario>> GetFuncionariosById(int id)
        {
            var ServiceResponse = new ServiceResponse<Usuario>();
            try
            {
                if (id == null)
                {
                    ServiceResponse.Dados = null;
                    ServiceResponse.Mensagem = "Usuário não identificado!";

                    return ServiceResponse;
                }

                var UsuarioRemover = _context.Usuarios.Find(id);

                ServiceResponse.Dados = UsuarioRemover;
                ServiceResponse.Mensagem = "Usuário encontrado!";
            }
            catch (Exception x)
            {
                ServiceResponse.Mensagem = x.Message;
            }

            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Usuario>>> GetUsuarios()
        {
            var ServiceResponse = new ServiceResponse<List<Usuario>>();

            try
            {
                ServiceResponse.Dados = _context.Usuarios.ToList();
                ServiceResponse.Mensagem = "Usuário trazidos com sucesso!";


            }
            catch (Exception x)
            {
                ServiceResponse.Mensagem = x.Message;
            }

            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Usuario>>> UpdateFuncionarios(Usuario modelUpdate, int id)
        {
            var serviceresponse = new ServiceResponse<List<Usuario>>();

            try
            {
                Usuario usuarioBanco = _context.Usuarios.Find(id);

                if (usuarioBanco == null)
                {
                    serviceresponse.Dados = null;
                    serviceresponse.Mensagem = "Usuário não foi encontrado!";
                }

                usuarioBanco.Nome = modelUpdate.Nome;
                usuarioBanco.Endereco = modelUpdate.Endereco;
                usuarioBanco.Telefone = modelUpdate.Telefone;
                usuarioBanco.Ocupacao = modelUpdate.Ocupacao;

                _context.Update(usuarioBanco);
                await _context.SaveChangesAsync();

                serviceresponse.Dados = _context.Usuarios.ToList();
                serviceresponse.Mensagem = "Usuário atualizado com sucesso!";

            }
            catch (Exception ex)
            {

                serviceresponse.Mensagem = ex.Message;
            }

            return serviceresponse;
        }
    }
}