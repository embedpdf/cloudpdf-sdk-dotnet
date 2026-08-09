using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(TokensIssueRequestTenantScopeItemZero.TokensIssueRequestTenantScopeItemZeroSerializer)
)]
[Serializable]
public readonly record struct TokensIssueRequestTenantScopeItemZero : IStringEnum
{
    public static readonly TokensIssueRequestTenantScopeItemZero All = new(Values.All);

    public TokensIssueRequestTenantScopeItemZero(string value)
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
    public static TokensIssueRequestTenantScopeItemZero FromCustom(string value)
    {
        return new TokensIssueRequestTenantScopeItemZero(value);
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

    public static bool operator ==(TokensIssueRequestTenantScopeItemZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TokensIssueRequestTenantScopeItemZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TokensIssueRequestTenantScopeItemZero value) =>
        value.Value;

    public static explicit operator TokensIssueRequestTenantScopeItemZero(string value) =>
        new(value);

    internal class TokensIssueRequestTenantScopeItemZeroSerializer
        : JsonConverter<TokensIssueRequestTenantScopeItemZero>
    {
        public override TokensIssueRequestTenantScopeItemZero Read(
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
            return new TokensIssueRequestTenantScopeItemZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TokensIssueRequestTenantScopeItemZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TokensIssueRequestTenantScopeItemZero ReadAsPropertyName(
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
            return new TokensIssueRequestTenantScopeItemZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TokensIssueRequestTenantScopeItemZero value,
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
        public const string All = "*";
    }
}
