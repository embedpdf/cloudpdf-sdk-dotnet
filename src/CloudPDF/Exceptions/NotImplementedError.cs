namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotImplementedError(EngineErrorPayload body, CloudPDF.RawResponse? rawResponse = null)
    : CloudPDFApiException("NotImplementedError", 501, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EngineErrorPayload Body => body;
}
