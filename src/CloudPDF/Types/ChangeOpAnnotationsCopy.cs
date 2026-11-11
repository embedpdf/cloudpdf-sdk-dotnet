using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeOpAnnotationsCopy : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("refs")]
    public IEnumerable<AnnotationRef> Refs { get; set; } = new List<AnnotationRef>();

    [JsonPropertyName("page")]
    public PageRef? Page { get; set; }

    [JsonPropertyName("offset")]
    public ChangeOpAnnotationsCopyOffset? Offset { get; set; }

    [JsonPropertyName("objectNumbers")]
    public IEnumerable<int>? ObjectNumbers { get; set; }

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
