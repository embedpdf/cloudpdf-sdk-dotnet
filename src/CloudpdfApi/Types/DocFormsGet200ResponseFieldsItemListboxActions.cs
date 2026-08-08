using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocFormsGet200ResponseFieldsItemListboxActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("keystroke")]
    public DocFormsGet200ResponseFieldsItemListboxActionsKeystroke? Keystroke { get; set; }

    [JsonPropertyName("format")]
    public DocFormsGet200ResponseFieldsItemListboxActionsFormat? Format { get; set; }

    [JsonPropertyName("validate")]
    public DocFormsGet200ResponseFieldsItemListboxActionsValidate? Validate { get; set; }

    [JsonPropertyName("calculate")]
    public DocFormsGet200ResponseFieldsItemListboxActionsCalculate? Calculate { get; set; }

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
