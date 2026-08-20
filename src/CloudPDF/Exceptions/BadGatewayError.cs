namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class BadGatewayError(
    DocumentsImportFrom502Response body,
    CloudPDF.RawResponse? rawResponse = null
) : CloudPDFApiException("BadGatewayError", 502, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new DocumentsImportFrom502Response Body => body;
}
