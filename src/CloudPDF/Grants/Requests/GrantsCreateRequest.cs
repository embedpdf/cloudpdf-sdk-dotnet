using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsCreateRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonPropertyName("docId")]
    public required string DocId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("layerMode")]
    public GrantsCreateRequestLayerMode? LayerMode { get; set; }

    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    [JsonPropertyName("keepVisitorLayers")]
    public bool? KeepVisitorLayers { get; set; }

    [JsonPropertyName("visitorIdleSeconds")]
    public int? VisitorIdleSeconds { get; set; }

    [JsonPropertyName("visitorIdentity")]
    public GrantsCreateRequestVisitorIdentity? VisitorIdentity { get; set; }

    [JsonPropertyName("identity")]
    public Identity? Identity { get; set; }

    [JsonPropertyName("scope")]
    public IEnumerable<string> Scope { get; set; } = new List<string>();

    [JsonPropertyName("origins")]
    public IEnumerable<string>? Origins { get; set; }

    [JsonPropertyName("passphrase")]
    public string? Passphrase { get; set; }

    [JsonPropertyName("sessionTtlSeconds")]
    public int? SessionTtlSeconds { get; set; }

    [JsonPropertyName("expiresAt")]
    public int? ExpiresAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
