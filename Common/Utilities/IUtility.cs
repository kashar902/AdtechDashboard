namespace Common.Utilities
{
    public interface IUtility
    {
        string GetBaseUrl();
        Task<string> GetEmailTemplate(string name, IDictionary<string, string> keyValues);
    }
}
