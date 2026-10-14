using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PagePositionZero.PagePositionZeroSerializer))]
[Serializable]
public readonly record struct PagePositionZero : IStringEnum
{
    public static readonly PagePositionZero Start = new(Values.Start);

    public static readonly PagePositionZero End = new(Values.End);

    public PagePositionZero(string value)
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
    public static PagePositionZero FromCustom(string value)
    {
        return new PagePositionZero(value);
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

    public static bool operator ==(PagePositionZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PagePositionZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PagePositionZero value) => value.Value;

    public static explicit operator PagePositionZero(string value) => new(value);

    internal class PagePositionZeroSerializer : JsonConverter<PagePositionZero>
    {
        public override PagePositionZero Read(
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
            return new PagePositionZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PagePositionZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PagePositionZero ReadAsPropertyName(
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
            return new PagePositionZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PagePositionZero value,
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
