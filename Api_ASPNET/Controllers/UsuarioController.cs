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

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Usuario>>>> CreateFuncionarios(Usuario modelCreate)
        {
            return Ok(await _UsuarioInterface.CreateFuncionarios(modelCreate));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Usuario>>>> DeleteFuncionarios(int id)
        {
            return Ok(await _UsuarioInterface.DeleteFuncionarios(id));
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioDTO>>> GetUsuarios()
        {
            var usuariosResponse = await _UsuarioInterface.GetUsuarios();

            if (usuariosResponse == null || usuariosResponse.Dados == null)
            {
                return NotFound();
            }

            var usuariosDTO = _mapper.Map<List<UsuarioDTO>>(usuariosResponse.Dados);

            return Ok(usuariosDTO);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDTO>> GetFuncionariosById(int id)
        {
            var usuario = await _UsuarioInterface.GetFuncionariosById(id);
            
            if (usuario == null || usuario.Dados == null)
            {
                return NotFound(); 
            }

            var usuarioDTO = _mapper.Map<UsuarioDTO>(usuario.Dados);

            return Ok(usuarioDTO);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<Usuario>>> UpdateFuncionarios(Usuario modelUpdate, int id)
        {
            return Ok(await _UsuarioInterface.UpdateFuncionarios(modelUpdate, id));
        }


    }
}