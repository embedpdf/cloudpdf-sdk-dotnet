namespace CloudPDF;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ContentTooLargeError(object body, CloudPDF.RawResponse? rawResponse = null)
    : CloudPDFApiException("ContentTooLargeError", 413, body, rawResponse: rawResponse);
