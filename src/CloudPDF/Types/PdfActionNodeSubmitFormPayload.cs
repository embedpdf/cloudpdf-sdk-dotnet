using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PdfActionNodeSubmitFormPayload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PdfActionTargetRef>? Fields { get; set; }

    [JsonPropertyName("exclude")]
    public required bool Exclude { get; set; }

    [JsonPropertyName("includeNoValueFields")]
    public required bool IncludeNoValueFields { get; set; }

    [JsonPropertyName("format")]
    public required PdfActionNodeSubmitFormPayloadFormat Format { get; set; }

    [JsonPropertyName("method")]
    public required PdfActionNodeSubmitFormPayloadMethod Method { get; set; }

    [JsonPropertyName("submitCoordinates")]
    public required bool SubmitCoordinates { get; set; }

    [JsonPropertyName("includeAppendSaves")]
    public required bool IncludeAppendSaves { get; set; }

    [JsonPropertyName("includeAnnotations")]
    public required bool IncludeAnnotations { get; set; }

    [JsonPropertyName("canonicalFormat")]
    public required bool CanonicalFormat { get; set; }

    [JsonPropertyName("exclNonUserAnnots")]
    public required bool ExclNonUserAnnots { get; set; }

    [JsonPropertyName("exclFKey")]
    public required bool ExclFKey { get; set; }

    [JsonPropertyName("embedForm")]
    public required bool EmbedForm { get; set; }

    [JsonPropertyName("charSet")]
    public string? CharSet { get; set; }

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
