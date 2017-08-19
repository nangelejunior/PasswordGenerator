using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfPasswordGenerator
{
    [ServiceContract]
    public interface IPasswordGenerator
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GetPasswords", BodyStyle=WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(CustomException))]
        string[] GetPasswords(string characters, int minSize, int maxSize, int numberPasswords);
    }

    [DataContract]
    public class CustomException
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ExceptionMessage { get; set; }
        [DataMember]
        public string InnerException { get; set; }
        [DataMember]
        public string StackTrace { get; set; }
    }
}
