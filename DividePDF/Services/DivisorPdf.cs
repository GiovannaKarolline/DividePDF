using DividePDF.DTOs;
using DividePDF.Services.Interfaces;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace DividePDF.Services
{
    public class DivisorPdf : IDivisorPdf
    {
        int numeroDocumento = 0;

        public async Task<List<string>> DividirAsync(IFormFile formfile)
        {
            if (formfile is not null)
            {
                Stream arquivoMaior = formfile.OpenReadStream();

                PdfDocument arquivo = PdfReader.Open(arquivoMaior, PdfDocumentOpenMode.Import);

                List<string> arquivosSeparados = new List<string>();

                foreach (PdfPage pagina in arquivo.Pages)
                {
                    PdfDocument novoArquivo = new PdfDocument();

                    novoArquivo.AddPage(pagina);

                    string caminhoNovoArquivo = $"Arquivos/ArquivosSeparados/documento - {++numeroDocumento}.pdf";

                    await novoArquivo.SaveAsync(caminhoNovoArquivo);

                    arquivosSeparados.Add(caminhoNovoArquivo);
                }

                return await Task.FromResult(arquivosSeparados);
            }

            return new List<string>();
        }
    }
}
