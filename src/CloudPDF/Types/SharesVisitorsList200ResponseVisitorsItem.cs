using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record SharesVisitorsList200ResponseVisitorsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("visitorId")]
    public required string VisitorId { get; set; }

    [JsonPropertyName("answers")]
    public required SharesVisitorsList200ResponseVisitorsItemAnswers Answers { get; set; }

    [JsonPropertyName("emailVerified")]
    public required bool EmailVerified { get; set; }

    [JsonPropertyName("consentedAt")]
    public double? ConsentedAt { get; set; }

    [JsonPropertyName("firstSeenAt")]
    public required double FirstSeenAt { get; set; }

    [JsonPropertyName("lastSeenAt")]
    public required double LastSeenAt { get; set; }

    [JsonPropertyName("layer")]
    public SharesVisitorsList200ResponseVisitorsItemLayer? Layer { get; set; }

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
