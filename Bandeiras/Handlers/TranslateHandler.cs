using System.Net;
using System.Web;

namespace Bandeiras.Handlers
{
    public class TranslateHandler
    {
        public String Translate(String input, string from = "en", string to = "pt")
        {
            var fromLanguage = from;
            var toLanguage = to;
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(input)}";
            var webclient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webclient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4
                    , StringComparison.Ordinal) - 4);
                return result;
            }
            catch (Exception e1)
            {
                return "error";
            }
        }
    }
}
