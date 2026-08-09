namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotFoundError(object body, CloudPDF.RawResponse? rawResponse = null)
    : CloudPDFApiException("NotFoundError", 404, body, rawResponse: rawResponse);
