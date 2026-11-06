using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesRemoveNameResponseLayoutLabelsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("firstPage")]
    public required int FirstPage { get; set; }

    [JsonPropertyName("style")]
    public DocPagesRemoveNameResponseLayoutLabelsItemStyle? Style { get; set; }

    [JsonPropertyName("firstNumber")]
    public required int FirstNumber { get; set; }

    [JsonPropertyName("prefix")]
    public required string Prefix { get; set; }

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
