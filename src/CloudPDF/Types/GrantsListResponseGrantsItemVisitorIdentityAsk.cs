using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsListResponseGrantsItemVisitorIdentityAsk.GrantsListResponseGrantsItemVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct GrantsListResponseGrantsItemVisitorIdentityAsk : IStringEnum
{
    public static readonly GrantsListResponseGrantsItemVisitorIdentityAsk OnOpen = new(
        Values.OnOpen
    );

    public static readonly GrantsListResponseGrantsItemVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public GrantsListResponseGrantsItemVisitorIdentityAsk(string value)
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
    public static GrantsListResponseGrantsItemVisitorIdentityAsk FromCustom(string value)
    {
        return new GrantsListResponseGrantsItemVisitorIdentityAsk(value);
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
        GrantsListResponseGrantsItemVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsListResponseGrantsItemVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GrantsListResponseGrantsItemVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator GrantsListResponseGrantsItemVisitorIdentityAsk(string value) =>
        new(value);

    internal class GrantsListResponseGrantsItemVisitorIdentityAskSerializer
        : JsonConverter<GrantsListResponseGrantsItemVisitorIdentityAsk>
    {
        public override GrantsListResponseGrantsItemVisitorIdentityAsk Read(
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
            return new GrantsListResponseGrantsItemVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsListResponseGrantsItemVisitorIdentityAsk ReadAsPropertyName(
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
            return new GrantsListResponseGrantsItemVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityAsk value,
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
