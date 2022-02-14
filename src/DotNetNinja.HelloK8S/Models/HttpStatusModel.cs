using System.Net;
namespace DotNetNinja.HelloK8S.Models;

public class HttpStatusModel
{
    public HttpStatusModel(HttpStatusCode status)
    {
        Status = status;
    }

    public HttpStatusCode Status { get; }

    public int StatusCode => (int)Status;
    public bool IsServerError => StatusCode >=500;
    public bool IsClientError => StatusCode >=400 && StatusCode<500;
    public bool IsOk => StatusCode >=200 && StatusCode < 300;
    public bool IsRedirect => StatusCode >=300 && StatusCode < 400;

    public string Description => UIHelper.HttpStatusDescriptions[Status];
    public string StatusClass => (IsServerError)?"danger":(IsClientError)?"warning":"success";
}