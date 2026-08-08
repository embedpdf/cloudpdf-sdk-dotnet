using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocFormsGet200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("formKind")]
    public required DocFormsGet200ResponseFormKind FormKind { get; set; }

    [JsonPropertyName("needsAppearances")]
    public required bool NeedsAppearances { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<DocFormsGet200ResponseFieldsItem> Fields { get; set; } =
        new List<DocFormsGet200ResponseFieldsItem>();

    [JsonPropertyName("calculationOrder")]
    public IEnumerable<DocFormsGet200ResponseCalculationOrderItem?> CalculationOrder { get; set; } =
        new List<DocFormsGet200ResponseCalculationOrderItem?>();

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
