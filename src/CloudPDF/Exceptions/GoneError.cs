namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class GoneError(SharesExchange410Response body, CloudPDF.RawResponse? rawResponse = null)
    : CloudPDFApiException("GoneError", 410, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new SharesExchange410Response Body => body;
}
