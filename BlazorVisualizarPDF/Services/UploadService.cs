using Microsoft.AspNetCore.Components.Forms;

namespace BlazorVisualizarPDF.Services;

public class UploadService : IUploadService
{
    private readonly long tamanhoMaximoPermitido = 1024 * 500; // 512.000 bytes ou seja 512 kilobytes
    private readonly IWebHostEnvironment _env;

    public UploadService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public async Task ArquivoUpload(IBrowserFile arquivo)
    {
        if (arquivo.Size > tamanhoMaximoPermitido)
        {
            throw new ArgumentException("Tamanho do arquivo excede o limite permitido");
        }
        else
        {
            try
            {
                var path = Path.Combine(_env.WebRootPath, "uploads", arquivo.Name);
                await using FileStream fs = new(path, FileMode.Create);
                await arquivo.OpenReadStream().CopyToAsync(fs);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
