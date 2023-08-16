using HtmlToImage;
using System.IO;
using System.Text;

namespace TestHtmlToImage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // From HTML string
            var converter = new HtmlConverter();
            var html = "<div><strong>Hello</strong> World!</div>";
            var htmlBytes = converter.FromHtmlString(html, 500, ImageFormat.Png, 100);
            File.WriteAllBytes("D:\\hello.png", htmlBytes);

            // From URL
            //var converter = new HtmlConverter();
            //var urlBytes = converter.FromUrl("http://localhost/", 800, format: ImageFormat.Png, quality: 100);
            //File.WriteAllBytes("D:\\localhost.png", urlBytes);
        }
    }
}