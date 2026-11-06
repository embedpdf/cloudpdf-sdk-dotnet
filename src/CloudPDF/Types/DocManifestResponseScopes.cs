using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocManifestResponseScopes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("content")]
    public required DocManifestResponseScopesContent Content { get; set; }

    [JsonPropertyName("annotations")]
    public required DocManifestResponseScopesAnnotations Annotations { get; set; }

    [JsonPropertyName("forms")]
    public required DocManifestResponseScopesForms Forms { get; set; }

    [JsonPropertyName("layout")]
    public required DocManifestResponseScopesLayout Layout { get; set; }

    [JsonPropertyName("attachments")]
    public required DocManifestResponseScopesAttachments Attachments { get; set; }

    [JsonPropertyName("metadata")]
    public required DocManifestResponseScopesMetadata Metadata { get; set; }

    [JsonPropertyName("actions")]
    public required DocManifestResponseScopesActions Actions { get; set; }

    [JsonPropertyName("outline")]
    public required DocManifestResponseScopesOutline Outline { get; set; }

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
