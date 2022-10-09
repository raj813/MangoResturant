// Will hold static etails
namespace Mango.web
{
    public class SD
    {
        public static string ProductAPIBase { get; set; }

        public enum ApiType 
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
