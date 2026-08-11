namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ConflictError(
    DocumentsUploadProxy409Response body,
    CloudPDF.RawResponse? rawResponse = null
) : CloudPDFApiException("ConflictError", 409, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new DocumentsUploadProxy409Response Body => body;
}
