using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreate200ResponseGrantVisitorIdentityAsk.GrantsCreate200ResponseGrantVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct GrantsCreate200ResponseGrantVisitorIdentityAsk : IStringEnum
{
    public static readonly GrantsCreate200ResponseGrantVisitorIdentityAsk OnOpen = new(
        Values.OnOpen
    );

    public static readonly GrantsCreate200ResponseGrantVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public GrantsCreate200ResponseGrantVisitorIdentityAsk(string value)
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
    public static GrantsCreate200ResponseGrantVisitorIdentityAsk FromCustom(string value)
    {
        return new GrantsCreate200ResponseGrantVisitorIdentityAsk(value);
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

    public static bool operator ==(
        GrantsCreate200ResponseGrantVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreate200ResponseGrantVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GrantsCreate200ResponseGrantVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator GrantsCreate200ResponseGrantVisitorIdentityAsk(string value) =>
        new(value);

    internal class GrantsCreate200ResponseGrantVisitorIdentityAskSerializer
        : JsonConverter<GrantsCreate200ResponseGrantVisitorIdentityAsk>
    {
        public override GrantsCreate200ResponseGrantVisitorIdentityAsk Read(
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
            return new GrantsCreate200ResponseGrantVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreate200ResponseGrantVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreate200ResponseGrantVisitorIdentityAsk ReadAsPropertyName(
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
            return new GrantsCreate200ResponseGrantVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreate200ResponseGrantVisitorIdentityAsk value,
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
        public const string OnOpen = "on-open";

        public const string BeforeFirstChange = "before-first-change";
    }
}
