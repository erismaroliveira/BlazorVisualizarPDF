using BlazorVisualizarPDF.Data;

namespace BlazorVisualizarPDF.Services;

public interface IArquivoService
{
    List<ArquivoPDF> GetPdfs();
}
