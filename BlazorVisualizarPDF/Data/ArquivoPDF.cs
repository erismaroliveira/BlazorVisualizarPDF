namespace BlazorVisualizarPDF.Data;

public class ArquivoPDF
{
    public int ArquivoId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public List<ArquivoPDF> Arquivos { get; set; } = new List<ArquivoPDF>();
}
