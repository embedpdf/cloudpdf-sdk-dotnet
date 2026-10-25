using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace CloudPDF;

[Serializable]
public record ChangeOpPagesInsertBlank : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("spec")]
    public required ChangeOpPagesInsertBlankSpec Spec { get; set; }

    [JsonPropertyName("position")]
    public OneOf<PagePositionZero, PagePositionAfter>? Position { get; set; }

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
