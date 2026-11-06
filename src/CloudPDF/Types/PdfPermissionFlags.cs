using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PdfPermissionFlags : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("print")]
    public required bool Print { get; set; }

    [JsonPropertyName("modifyContents")]
    public required bool ModifyContents { get; set; }

    [JsonPropertyName("copy")]
    public required bool Copy { get; set; }

    [JsonPropertyName("modifyAnnotations")]
    public required bool ModifyAnnotations { get; set; }

    [JsonPropertyName("fillForms")]
    public required bool FillForms { get; set; }

    [JsonPropertyName("copyForAccessibility")]
    public required bool CopyForAccessibility { get; set; }

    [JsonPropertyName("assemble")]
    public required bool Assemble { get; set; }

    [JsonPropertyName("printHighQuality")]
    public required bool PrintHighQuality { get; set; }

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
