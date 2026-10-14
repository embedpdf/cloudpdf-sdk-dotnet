using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FieldPositionZero.FieldPositionZeroSerializer))]
[Serializable]
public readonly record struct FieldPositionZero : IStringEnum
{
    public static readonly FieldPositionZero Start = new(Values.Start);

    public static readonly FieldPositionZero End = new(Values.End);

    public FieldPositionZero(string value)
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
    public static FieldPositionZero FromCustom(string value)
    {
        return new FieldPositionZero(value);
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

    public static bool operator ==(FieldPositionZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldPositionZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldPositionZero value) => value.Value;

    public static explicit operator FieldPositionZero(string value) => new(value);

    internal class FieldPositionZeroSerializer : JsonConverter<FieldPositionZero>
    {
        public override FieldPositionZero Read(
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
            return new FieldPositionZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FieldPositionZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FieldPositionZero ReadAsPropertyName(
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
            return new FieldPositionZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FieldPositionZero value,
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
