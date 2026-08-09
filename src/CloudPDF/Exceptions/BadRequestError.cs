namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class BadRequestError(object body, CloudPDF.RawResponse? rawResponse = null)
    : CloudPDFApiException("BadRequestError", 400, body, rawResponse: rawResponse);
