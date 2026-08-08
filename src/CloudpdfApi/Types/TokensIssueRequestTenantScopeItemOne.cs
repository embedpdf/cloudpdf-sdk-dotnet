using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(TokensIssueRequestTenantScopeItemOne.TokensIssueRequestTenantScopeItemOneSerializer)
)]
[Serializable]
public readonly record struct TokensIssueRequestTenantScopeItemOne : IStringEnum
{
    public static readonly TokensIssueRequestTenantScopeItemOne DocsCreate = new(Values.DocsCreate);

    public static readonly TokensIssueRequestTenantScopeItemOne DocsRead = new(Values.DocsRead);

    public static readonly TokensIssueRequestTenantScopeItemOne DocsDelete = new(Values.DocsDelete);

    public static readonly TokensIssueRequestTenantScopeItemOne TokensIssueDoc = new(
        Values.TokensIssueDoc
    );

    public static readonly TokensIssueRequestTenantScopeItemOne TokensRevoke = new(
        Values.TokensRevoke
    );

    public TokensIssueRequestTenantScopeItemOne(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static TokensIssueRequestTenantScopeItemOne FromCustom(string value)
    {
        return new TokensIssueRequestTenantScopeItemOne(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(TokensIssueRequestTenantScopeItemOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TokensIssueRequestTenantScopeItemOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TokensIssueRequestTenantScopeItemOne value) =>
        value.Value;

    public static explicit operator TokensIssueRequestTenantScopeItemOne(string value) =>
        new(value);

    internal class TokensIssueRequestTenantScopeItemOneSerializer
        : JsonConverter<TokensIssueRequestTenantScopeItemOne>
    {
        public override TokensIssueRequestTenantScopeItemOne Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new TokensIssueRequestTenantScopeItemOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TokensIssueRequestTenantScopeItemOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TokensIssueRequestTenantScopeItemOne ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new TokensIssueRequestTenantScopeItemOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TokensIssueRequestTenantScopeItemOne value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DocsCreate = "docs.create";

        public const string DocsRead = "docs.read";

        public const string DocsDelete = "docs.delete";

        public const string TokensIssueDoc = "tokens.issue-doc";

        public const string TokensRevoke = "tokens.revoke";
    }
}
