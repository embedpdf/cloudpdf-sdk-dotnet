using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(OutlinePositionZero.OutlinePositionZeroSerializer))]
[Serializable]
public readonly record struct OutlinePositionZero : IStringEnum
{
    public static readonly OutlinePositionZero Start = new(Values.Start);

    public static readonly OutlinePositionZero End = new(Values.End);

    public OutlinePositionZero(string value)
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
    public static OutlinePositionZero FromCustom(string value)
    {
        return new OutlinePositionZero(value);
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

    public static bool operator ==(OutlinePositionZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OutlinePositionZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OutlinePositionZero value) => value.Value;

    public static explicit operator OutlinePositionZero(string value) => new(value);

    internal class OutlinePositionZeroSerializer : JsonConverter<OutlinePositionZero>
    {
        public override OutlinePositionZero Read(
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
            return new OutlinePositionZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OutlinePositionZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OutlinePositionZero ReadAsPropertyName(
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
            return new OutlinePositionZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OutlinePositionZero value,
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
        public const string Start = "start";

        public const string End = "end";
    }
}
