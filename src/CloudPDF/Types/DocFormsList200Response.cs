using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocFormsList200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("formKind")]
    public required DocFormsList200ResponseFormKind FormKind { get; set; }

    [JsonPropertyName("needsAppearances")]
    public required bool NeedsAppearances { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<FormField> Fields { get; set; } = new List<FormField>();

    [JsonPropertyName("widgets")]
    public IEnumerable<WidgetAnnotation> Widgets { get; set; } = new List<WidgetAnnotation>();

    [JsonPropertyName("calculationOrder")]
    public IEnumerable<FormFieldRef?> CalculationOrder { get; set; } = new List<FormFieldRef?>();

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
