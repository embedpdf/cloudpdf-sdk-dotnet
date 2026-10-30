using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateRequestVisitorIdentityAsk.GrantsCreateRequestVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateRequestVisitorIdentityAsk : IStringEnum
{
    public static readonly GrantsCreateRequestVisitorIdentityAsk OnOpen = new(Values.OnOpen);

    public static readonly GrantsCreateRequestVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public GrantsCreateRequestVisitorIdentityAsk(string value)
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
    public static GrantsCreateRequestVisitorIdentityAsk FromCustom(string value)
    {
        return new GrantsCreateRequestVisitorIdentityAsk(value);
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

    public static bool operator ==(GrantsCreateRequestVisitorIdentityAsk value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsCreateRequestVisitorIdentityAsk value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsCreateRequestVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator GrantsCreateRequestVisitorIdentityAsk(string value) =>
        new(value);

    internal class GrantsCreateRequestVisitorIdentityAskSerializer
        : JsonConverter<GrantsCreateRequestVisitorIdentityAsk>
    {
        public override GrantsCreateRequestVisitorIdentityAsk Read(
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
            return new GrantsCreateRequestVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateRequestVisitorIdentityAsk ReadAsPropertyName(
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
            return new GrantsCreateRequestVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityAsk value,
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
