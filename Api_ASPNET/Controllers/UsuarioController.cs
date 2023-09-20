using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using houseasy_API.DTOs;
using houseasy_API.Models;
using houseasy_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace houseasy_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioInterface _UsuarioInterface;
        private readonly IMapper _mapper;
        public UsuarioController(IUsuarioInterface usuarioInterface, IMapper mapper)
        {
            _UsuarioInterface = usuarioInterface;
            _mapper = mapper;
        }

        [HttpPost("DTO")]
        public async Task<ActionResult<ServiceResponse<List<Usuario>>>> CreateFuncionarios(Usuario modelCreate)
        {
            var usuariosResponse = await _UsuarioInterface.CreateFuncionarios(modelCreate);

            if (usuariosResponse == null || usuariosResponse.Dados == null)
            {
                return NotFound();
            }

            var usuariosDTO = _mapper.Map<List<UsuarioDTO>>(usuariosResponse.Dados);

            var serviceresponse = new ServiceResponse<List<UsuarioDTO>>(); 
            serviceresponse.Dados = usuariosDTO;
            serviceresponse.Mensagem = "Criação Ok!";
            return Ok(serviceresponse);
        }

        [HttpDelete("DTO/{id}")]
        public async Task<ActionResult<ServiceResponse<List<UsuarioDTO>>>> DeleteFuncionarios(int id)
        {
            var usuariosResponse = await _UsuarioInterface.DeleteFuncionarios(id);

            if (usuariosResponse == null || usuariosResponse.Dados == null)
            {
                return NotFound();
            }

            var usuariosDTO = _mapper.Map<List<UsuarioDTO>>(usuariosResponse.Dados);

            var serviceresponse = new ServiceResponse<List<UsuarioDTO>>(); 
            serviceresponse.Dados = usuariosDTO;
            serviceresponse.Mensagem = "Exclusão, Ok!";
            return Ok(serviceresponse);
        }

        [HttpGet("DTO")]
        public async Task<ActionResult<ServiceResponse<List<UsuarioDTO>>>> GetUsuarios()
        {
            var usuariosResponse = await _UsuarioInterface.GetUsuarios();

            if (usuariosResponse == null || usuariosResponse.Dados == null)
            {
                return NotFound();
            }

            var usuariosDTO = _mapper.Map<List<UsuarioDTO>>(usuariosResponse.Dados);

            var serviceresponse = new ServiceResponse<List<UsuarioDTO>>(); 
            serviceresponse.Dados = usuariosDTO;
            serviceresponse.Mensagem = "Requicição dos itens, Ok!";
            return Ok(serviceresponse);
        }


        [HttpGet("DTO/{id}")]
        public async Task<ActionResult<UsuarioDTO>> GetFuncionariosById(int id)
        {
            var usuario = await _UsuarioInterface.GetFuncionariosById(id);
            
            if (usuario == null || usuario.Dados == null)
            {
                return NotFound(); 
            }

            var usuarioDTO = _mapper.Map<UsuarioDTO>(usuario.Dados);
            var serviceresponse = new ServiceResponse<UsuarioDTO>(); 
            serviceresponse.Dados = usuarioDTO;
            serviceresponse.Mensagem = "Busca pelo ID, Ok!";
            return Ok(serviceresponse);
        }


        [HttpPut("DTO/{id}")]
        public async Task<ActionResult<ServiceResponse<Usuario>>> UpdateFuncionarios(Usuario modelUpdate, int id)
        {
            var usuariosResponse = await _UsuarioInterface.UpdateFuncionarios(modelUpdate, id);

            if (usuariosResponse == null || usuariosResponse.Dados == null)
            {
                return NotFound();
            }

            var usuariosDTO = _mapper.Map<List<UsuarioDTO>>(usuariosResponse.Dados);

            var serviceresponse = new ServiceResponse<List<UsuarioDTO>>(); 
            serviceresponse.Dados = usuariosDTO;
            serviceresponse.Mensagem = "Atualização Ok!";
            return Ok(serviceresponse);
        }


    }
}