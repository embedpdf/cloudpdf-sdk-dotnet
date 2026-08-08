namespace CloudpdfApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotFoundError(object body, CloudpdfApi.RawResponse? rawResponse = null)
    : CloudpdfApiApiException("NotFoundError", 404, body, rawResponse: rawResponse);
