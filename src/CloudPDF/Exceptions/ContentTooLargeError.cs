namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ContentTooLargeError(EngineErrorPayload body, CloudPDF.RawResponse? rawResponse = null)
    : CloudPDFApiException("ContentTooLargeError", 413, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EngineErrorPayload Body => body;
}
