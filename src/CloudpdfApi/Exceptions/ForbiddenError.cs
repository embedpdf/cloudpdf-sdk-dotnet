namespace CloudpdfApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ForbiddenError(object body, CloudpdfApi.RawResponse? rawResponse = null)
    : CloudpdfApiApiException("ForbiddenError", 403, body, rawResponse: rawResponse);
