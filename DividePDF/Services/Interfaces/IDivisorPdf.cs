using DividePDF.DTOs;

namespace DividePDF.Services.Interfaces
{
    public interface IDivisorPdf
    {
        Task<List<string>> DividirAsync(IFormFile formfile);
    }
}
