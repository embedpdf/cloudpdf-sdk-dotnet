using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesViewports200ResponseItemMeasureRlAreaItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("unit")]
    public required string Unit { get; set; }

    [JsonPropertyName("conversion")]
    public double? Conversion { get; set; }

    [JsonPropertyName("fraction")]
    public DocPagesViewports200ResponseItemMeasureRlAreaItemFraction? Fraction { get; set; }

    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    [JsonPropertyName("fixed")]
    public bool? Fixed { get; set; }

    [JsonPropertyName("thousands")]
    public string? Thousands { get; set; }

    [JsonPropertyName("decimal")]
    public string? Decimal { get; set; }

    [JsonPropertyName("prefixSpacing")]
    public string? PrefixSpacing { get; set; }

    [JsonPropertyName("suffixSpacing")]
    public string? SuffixSpacing { get; set; }

    [JsonPropertyName("labelPosition")]
    public DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition? LabelPosition { get; set; }

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
