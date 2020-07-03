using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Repository
{
    public interface IFileRepository
    {
        Task<bool> PutFileAsync(string path, IFormFile file);
    }
}