using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PdfActionWriteSubmitForm : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PdfActionTargetRef>? Fields { get; set; }

    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    [JsonPropertyName("includeNoValueFields")]
    public bool? IncludeNoValueFields { get; set; }

    [JsonPropertyName("format")]
    public PdfActionWriteSubmitFormFormat? Format { get; set; }

    [JsonPropertyName("method")]
    public PdfActionWriteSubmitFormMethod? Method { get; set; }

    [JsonPropertyName("submitCoordinates")]
    public bool? SubmitCoordinates { get; set; }

    [JsonPropertyName("includeAppendSaves")]
    public bool? IncludeAppendSaves { get; set; }

    [JsonPropertyName("includeAnnotations")]
    public bool? IncludeAnnotations { get; set; }

    [JsonPropertyName("canonicalFormat")]
    public bool? CanonicalFormat { get; set; }

    [JsonPropertyName("exclNonUserAnnots")]
    public bool? ExclNonUserAnnots { get; set; }

    [JsonPropertyName("exclFKey")]
    public bool? ExclFKey { get; set; }

    [JsonPropertyName("embedForm")]
    public bool? EmbedForm { get; set; }

    [JsonPropertyName("next")]
    public IEnumerable<object>? Next { get; set; }

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
