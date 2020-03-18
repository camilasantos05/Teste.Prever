using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Application.Contrete;
using WebAPI.Domain;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {
        private readonly AppServiceBase<Cotacao> _appServiceBase;

        public CotacaoController(AppServiceBase<Cotacao> appServiceBase)
        {
            _appServiceBase = appServiceBase;
        }

        // GET: api/Cotacao
        [HttpGet]
        public IEnumerable<Cotacao> GetCotacaos()
        {
            return _appServiceBase.GetAll();
        }


        // PUT: api/Cotacao/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCotacao(int id, Cotacao Cotacao)
        {
            if (id != Cotacao.Id)
            {
                return BadRequest();
            }

            try
            {
                _appServiceBase.Save(Cotacao);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CotacaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // GET: api/Cotacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cotacao>> GetCotacao(int id)
        {
            var Cotacao = _appServiceBase.GetById(id);

            if (Cotacao == null)
            {
                return NotFound();
            }

            return Cotacao;
        }

        // POST: api/Cotacao
        [HttpPost]
        public async Task<ActionResult<Cotacao>> PostCotacao(Cotacao Cotacao)
        {
            _appServiceBase.Add(Cotacao);
            await _appServiceBase.SaveAsync(Cotacao);

            return CreatedAtAction("GetCotacao", new { id = Cotacao.Id }, Cotacao);
        }

        // DELETE: api/Cotacao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cotacao>> DeleteCotacao(int id)
        {
            var Cotacao = _appServiceBase.GetById(id);
            if (Cotacao == null)
            {
                return NotFound();
            }

            _appServiceBase.Remove(Cotacao);
            await _appServiceBase.SaveAsync(Cotacao);

            return Cotacao;
        }

        private bool CotacaoExists(int id)
        {
            var consulta = _appServiceBase.GetById(id);
            if (consulta != null)
                return true;

            return false;
        }
    }
}
