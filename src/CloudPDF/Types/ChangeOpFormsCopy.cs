using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeOpFormsCopy : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fields")]
    public IEnumerable<FormFieldRef> Fields { get; set; } = new List<FormFieldRef>();

    [JsonPropertyName("widgets")]
    public IEnumerable<AnnotationRef>? Widgets { get; set; }

    [JsonPropertyName("page")]
    public PageRef? Page { get; set; }

    [JsonPropertyName("offset")]
    public ChangeOpFormsCopyOffset? Offset { get; set; }

    [JsonPropertyName("values")]
    public bool? Values { get; set; }

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
