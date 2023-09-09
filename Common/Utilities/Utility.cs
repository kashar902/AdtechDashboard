using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Common.Utilities
{
    public class Utility : IUtility
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHostingEnvironment _hostEnvironment;
        public Utility(IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostEnvironment)
        {
            _httpContextAccessor = httpContextAccessor;
            _hostEnvironment = hostEnvironment;
        }

        public string GetBaseUrl()
        {
            var request = _httpContextAccessor.HttpContext?.Request;
            return $"{request?.Scheme}://{request?.Host}";
        }

        public async Task<string> GetEmailTemplate(string name, IDictionary<string, string> keyValues)
        {
            var templatesPath = Path.Join(_hostEnvironment.WebRootPath, "EmailTemplates");
            CreateEmailTemplateFolder(templatesPath);

            var htmlTemplate = await ReadHtmlTemplate(Path.Join(templatesPath, $"{name}.html"));
            foreach (var keyValue in keyValues)
            {
                htmlTemplate = htmlTemplate.Replace(keyValue.Key, keyValue.Value);
            }
            return htmlTemplate;

        }
        private async Task<string> ReadHtmlTemplate(string path)
        {
            if (!File.Exists(path))
            {
                return string.Empty;
            }

            return await File.ReadAllTextAsync(path);
        }
        private void CreateEmailTemplateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
