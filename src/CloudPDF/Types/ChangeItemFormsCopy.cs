using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeItemFormsCopy : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fields")]
    public IEnumerable<FormField> Fields { get; set; } = new List<FormField>();

    [JsonPropertyName("widgets")]
    public IEnumerable<WidgetAnnotation> Widgets { get; set; } = new List<WidgetAnnotation>();

    [JsonPropertyName("refMap")]
    public IEnumerable<ChangeItemFormsCopyRefMapItem> RefMap { get; set; } =
        new List<ChangeItemFormsCopyRefMapItem>();

    [JsonPropertyName("dropped")]
    public IEnumerable<ChangeItemFormsCopyDroppedItem> Dropped { get; set; } =
        new List<ChangeItemFormsCopyDroppedItem>();

    [JsonPropertyName("calculationOrder")]
    public IEnumerable<FormFieldRef>? CalculationOrder { get; set; }

    [JsonPropertyName("meta")]
    public required FormMutationMeta Meta { get; set; }

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
