using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FontSource.FontSourceSerializer))]
[Serializable]
public readonly record struct FontSource : IStringEnum
{
    public static readonly FontSource Standard = new(Values.Standard);

    public static readonly FontSource Engine = new(Values.Engine);

    public static readonly FontSource Document = new(Values.Document);

    public FontSource(string value)
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
    public static FontSource FromCustom(string value)
    {
        return new FontSource(value);
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

    public static bool operator ==(FontSource value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(FontSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontSource value) => value.Value;

    public static explicit operator FontSource(string value) => new(value);

    internal class FontSourceSerializer : JsonConverter<FontSource>
    {
        public override FontSource Read(
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
            return new FontSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontSource ReadAsPropertyName(
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
            return new FontSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontSource value,
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
        public const string Standard = "standard";

        public const string Engine = "engine";

        public const string Document = "document";
    }
}
