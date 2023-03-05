﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proveit.DAO;

namespace proveit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListarCategorias()
        {
            var dao = new CategoriaDAO();
            var usuarios = dao.ListarCategorias();

            return Ok(usuarios);
        }
    }
}
