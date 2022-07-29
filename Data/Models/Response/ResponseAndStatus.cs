namespace Kamall_foods_server_aspNetCore.Data.Models.Response;

public class ResponseAndStatus
{
    public int StatusCode;
    public string Message;

    public ResponseAndStatus(string message, int code)
    {
        StatusCode = code;
        Message = message;
    }
}