namespace Aspose.Email.Cloud.Live.Demos.UI.Models
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string FileName { get; set; }

        public override string ToString()
        {
            return $"{StatusCode}|{FileName}";
        }
    }
}