using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsList200ResponseGrantsItemVisitorIdentityAsk.GrantsList200ResponseGrantsItemVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct GrantsList200ResponseGrantsItemVisitorIdentityAsk : IStringEnum
{
    public static readonly GrantsList200ResponseGrantsItemVisitorIdentityAsk OnOpen = new(
        Values.OnOpen
    );

    public static readonly GrantsList200ResponseGrantsItemVisitorIdentityAsk BeforeFirstChange =
        new(Values.BeforeFirstChange);

    public GrantsList200ResponseGrantsItemVisitorIdentityAsk(string value)
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
    public static GrantsList200ResponseGrantsItemVisitorIdentityAsk FromCustom(string value)
    {
        return new GrantsList200ResponseGrantsItemVisitorIdentityAsk(value);
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
        GrantsList200ResponseGrantsItemVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsList200ResponseGrantsItemVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsList200ResponseGrantsItemVisitorIdentityAsk value
    ) => value.Value;

    public static explicit operator GrantsList200ResponseGrantsItemVisitorIdentityAsk(
        string value
    ) => new(value);

    internal class GrantsList200ResponseGrantsItemVisitorIdentityAskSerializer
        : JsonConverter<GrantsList200ResponseGrantsItemVisitorIdentityAsk>
    {
        public override GrantsList200ResponseGrantsItemVisitorIdentityAsk Read(
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
            return new GrantsList200ResponseGrantsItemVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsList200ResponseGrantsItemVisitorIdentityAsk ReadAsPropertyName(
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
            return new GrantsList200ResponseGrantsItemVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemVisitorIdentityAsk value,
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
