using Microsoft.AspNetCore.Components.Forms;

namespace BlazorVisualizarPDF.Services;

public interface IUploadService
{
    Task ArquivoUpload(IBrowserFile arquivo);
}
