using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace CloudPDF;

[Serializable]
public record ChangeOpOutlineCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("parent")]
    public OutlineItemRef? Parent { get; set; }

    [JsonPropertyName("position")]
    public OneOf<OutlinePositionZero, OutlinePositionAfter>? Position { get; set; }

    [JsonPropertyName("data")]
    public required OutlineItemDraft Data { get; set; }

    [JsonPropertyName("objectNumber")]
    public int? ObjectNumber { get; set; }

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
