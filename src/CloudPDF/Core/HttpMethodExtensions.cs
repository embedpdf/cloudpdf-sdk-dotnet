using global::System.Net.Http;

namespace CloudPDF.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
