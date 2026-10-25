using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(OutlineItemRefKind.OutlineItemRefKindSerializer))]
[Serializable]
public readonly record struct OutlineItemRefKind : IStringEnum
{
    public static readonly OutlineItemRefKind ObjectNumber = new(Values.ObjectNumber);

    public OutlineItemRefKind(string value)
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
    public static OutlineItemRefKind FromCustom(string value)
    {
        return new OutlineItemRefKind(value);
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

    public static bool operator ==(OutlineItemRefKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OutlineItemRefKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OutlineItemRefKind value) => value.Value;

    public static explicit operator OutlineItemRefKind(string value) => new(value);

    internal class OutlineItemRefKindSerializer : JsonConverter<OutlineItemRefKind>
    {
        public override OutlineItemRefKind Read(
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
            return new OutlineItemRefKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OutlineItemRefKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OutlineItemRefKind ReadAsPropertyName(
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
            return new OutlineItemRefKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OutlineItemRefKind value,
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
        public const string ObjectNumber = "objectNumber";
    }
}
