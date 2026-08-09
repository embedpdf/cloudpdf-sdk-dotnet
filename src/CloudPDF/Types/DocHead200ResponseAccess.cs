using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocHead200ResponseAccess : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("required")]
    public required bool Required { get; set; }

    [JsonPropertyName("reasons")]
    public IEnumerable<DocHead200ResponseAccessReasonsItem> Reasons { get; set; } =
        new List<DocHead200ResponseAccessReasonsItem>();

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

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
