using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FontProgramEmbedded.FontProgramEmbeddedSerializer))]
[Serializable]
public readonly record struct FontProgramEmbedded : IStringEnum
{
    public static readonly FontProgramEmbedded Whole = new(Values.Whole);

    public static readonly FontProgramEmbedded Subset = new(Values.Subset);

    public static readonly FontProgramEmbedded None = new(Values.None);

    public FontProgramEmbedded(string value)
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
    public static FontProgramEmbedded FromCustom(string value)
    {
        return new FontProgramEmbedded(value);
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

    public static bool operator ==(FontProgramEmbedded value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FontProgramEmbedded value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontProgramEmbedded value) => value.Value;

    public static explicit operator FontProgramEmbedded(string value) => new(value);

    internal class FontProgramEmbeddedSerializer : JsonConverter<FontProgramEmbedded>
    {
        public override FontProgramEmbedded Read(
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
            return new FontProgramEmbedded(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontProgramEmbedded value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontProgramEmbedded ReadAsPropertyName(
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
            return new FontProgramEmbedded(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontProgramEmbedded value,
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
        public const string Whole = "whole";

        public const string Subset = "subset";

        public const string None = "none";
    }
}
