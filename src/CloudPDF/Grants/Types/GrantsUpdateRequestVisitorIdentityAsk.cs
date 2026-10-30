using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsUpdateRequestVisitorIdentityAsk.GrantsUpdateRequestVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct GrantsUpdateRequestVisitorIdentityAsk : IStringEnum
{
    public static readonly GrantsUpdateRequestVisitorIdentityAsk OnOpen = new(Values.OnOpen);

    public static readonly GrantsUpdateRequestVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public GrantsUpdateRequestVisitorIdentityAsk(string value)
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
    public static GrantsUpdateRequestVisitorIdentityAsk FromCustom(string value)
    {
        return new GrantsUpdateRequestVisitorIdentityAsk(value);
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

    public static bool operator ==(GrantsUpdateRequestVisitorIdentityAsk value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsUpdateRequestVisitorIdentityAsk value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsUpdateRequestVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator GrantsUpdateRequestVisitorIdentityAsk(string value) =>
        new(value);

    internal class GrantsUpdateRequestVisitorIdentityAskSerializer
        : JsonConverter<GrantsUpdateRequestVisitorIdentityAsk>
    {
        public override GrantsUpdateRequestVisitorIdentityAsk Read(
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
            return new GrantsUpdateRequestVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsUpdateRequestVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsUpdateRequestVisitorIdentityAsk ReadAsPropertyName(
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
            return new GrantsUpdateRequestVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsUpdateRequestVisitorIdentityAsk value,
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
