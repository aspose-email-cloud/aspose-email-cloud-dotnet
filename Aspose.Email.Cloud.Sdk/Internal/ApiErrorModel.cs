using System;

namespace Aspose.Email.Cloud.Sdk
{
    public class ApiErrorModel
    {
        public ApiErrorDataModel Error { get; set; }
    }

    public class ApiErrorDataModel
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public InnerApiErrorModel InnerError { get; set; }
    }

    public class InnerApiErrorModel
    {
        public string RequestId { get; set; }
        public DateTime Date { get; set; }
    }
}