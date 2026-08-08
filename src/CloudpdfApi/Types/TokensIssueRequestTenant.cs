using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace CloudpdfApi;

[Serializable]
public record TokensIssueRequestTenant : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("sub")]
    public required string Sub { get; set; }

    [JsonPropertyName("scope")]
    public IEnumerable<
        OneOf<TokensIssueRequestTenantScopeItemZero, TokensIssueRequestTenantScopeItemOne>
    > Scope { get; set; } =
        new List<
            OneOf<TokensIssueRequestTenantScopeItemZero, TokensIssueRequestTenantScopeItemOne>
        >();

    [JsonPropertyName("expiresIn")]
    public required int ExpiresIn { get; set; }

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
