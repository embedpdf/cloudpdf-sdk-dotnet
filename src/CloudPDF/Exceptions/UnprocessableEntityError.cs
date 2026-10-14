namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class UnprocessableEntityError(
    AdminErrorPayload body,
    CloudPDF.RawResponse? rawResponse = null
) : CloudPDFApiException("UnprocessableEntityError", 422, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new AdminErrorPayload Body => body;
}
