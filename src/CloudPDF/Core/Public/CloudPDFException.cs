namespace CloudPDF;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class CloudPDFException(string message, Exception? innerException = null)
    : Exception(message, innerException);
