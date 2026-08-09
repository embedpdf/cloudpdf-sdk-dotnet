using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocFormsGet200ResponseFieldsItemRadioWidgetsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("annotObjectNumber")]
    public required int AnnotObjectNumber { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("onState")]
    public required string OnState { get; set; }

    [JsonPropertyName("exportValue")]
    public required string ExportValue { get; set; }

    [JsonPropertyName("checked")]
    public required bool Checked { get; set; }

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
