using BlazorVisualizarPDF.Data;

namespace BlazorVisualizarPDF.Services;

public class ArquivoService : IArquivoService
{
    private readonly IWebHostEnvironment _env;

    public ArquivoService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public List<ArquivoPDF> GetPdfs()
    {
        var arquivos = new List<ArquivoPDF>();
        string path = $"{_env.WebRootPath}\\uploads\\";

        int arquivoId = 1;

        foreach (var pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
        {
            arquivos.Add(new ArquivoPDF()
            {
                ArquivoId = arquivoId++,
                Nome = Path.GetFileName(pdfPath),
                Path = pdfPath
            });
        }

        return arquivos;
    }
}
