using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[Serializable]
public record AnalysisSignaturesRequest
{
    [JsonIgnore]
    public required string DocId { get; set; }

    [JsonIgnore]
    public required string LayerName { get; set; }

    [JsonIgnore]
    public int? SinceSignature { get; set; }

    [JsonIgnore]
    public int? SinceRevision { get; set; }

    [JsonIgnore]
    public AnalysisSignaturesRequestLevel? Level { get; set; }

    /// <summary>
    /// Base64-encoded password for an encrypted document. Valid only with the API token (403 anywhere else). An encrypted document answers 422 DocPasswordRequired when the header is absent. Viewer doc JWTs use the SDK password-session flow instead.
    /// </summary>
    [JsonIgnore]
    public string? DocumentPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
