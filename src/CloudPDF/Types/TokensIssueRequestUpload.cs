using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record TokensIssueRequestUpload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("sub")]
    public required string Sub { get; set; }

    /// <summary>
    /// A folder id, or root for the top level.
    /// </summary>
    [JsonPropertyName("folderId")]
    public string? FolderId { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object?>? Metadata { get; set; }

    [JsonPropertyName("maxFiles")]
    public int? MaxFiles { get; set; }

    [JsonPropertyName("maxBytes")]
    public int? MaxBytes { get; set; }

    [JsonPropertyName("origins")]
    public IEnumerable<string>? Origins { get; set; }

    [JsonPropertyName("expiresIn")]
    public required int ExpiresIn { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
