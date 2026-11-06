using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateResponseGrantVisitorIdentityAsk.GrantsCreateResponseGrantVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateResponseGrantVisitorIdentityAsk : IStringEnum
{
    public static readonly GrantsCreateResponseGrantVisitorIdentityAsk OnOpen = new(Values.OnOpen);

    public static readonly GrantsCreateResponseGrantVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public GrantsCreateResponseGrantVisitorIdentityAsk(string value)
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
    public static GrantsCreateResponseGrantVisitorIdentityAsk FromCustom(string value)
    {
        return new GrantsCreateResponseGrantVisitorIdentityAsk(value);
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
        GrantsCreateResponseGrantVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreateResponseGrantVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GrantsCreateResponseGrantVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator GrantsCreateResponseGrantVisitorIdentityAsk(string value) =>
        new(value);

    internal class GrantsCreateResponseGrantVisitorIdentityAskSerializer
        : JsonConverter<GrantsCreateResponseGrantVisitorIdentityAsk>
    {
        public override GrantsCreateResponseGrantVisitorIdentityAsk Read(
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
            return new GrantsCreateResponseGrantVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateResponseGrantVisitorIdentityAsk ReadAsPropertyName(
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
            return new GrantsCreateResponseGrantVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantVisitorIdentityAsk value,
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
