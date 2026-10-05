using DividePDF.DTOs;
using DividePDF.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DividePDF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PDFController : Controller
    {
        private readonly IDivisorPdf _divisorService;

        public PDFController(IDivisorPdf divisorService)
        {
            _divisorService = divisorService;
        }

        [HttpPost]
        public async Task<ActionResult> Dividir( [FromForm] DividirPdfDto dto) 
        {
            return Ok(await _divisorService.DividirAsync(dto.ArquivoRecebido));
        }
    }
}