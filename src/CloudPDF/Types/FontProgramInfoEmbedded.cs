using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FontProgramInfoEmbedded.FontProgramInfoEmbeddedSerializer))]
[Serializable]
public readonly record struct FontProgramInfoEmbedded : IStringEnum
{
    public static readonly FontProgramInfoEmbedded Whole = new(Values.Whole);

    public static readonly FontProgramInfoEmbedded Subset = new(Values.Subset);

    public static readonly FontProgramInfoEmbedded None = new(Values.None);

    public FontProgramInfoEmbedded(string value)
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
    public static FontProgramInfoEmbedded FromCustom(string value)
    {
        return new FontProgramInfoEmbedded(value);
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

    public static bool operator ==(FontProgramInfoEmbedded value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FontProgramInfoEmbedded value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontProgramInfoEmbedded value) => value.Value;

    public static explicit operator FontProgramInfoEmbedded(string value) => new(value);

    internal class FontProgramInfoEmbeddedSerializer : JsonConverter<FontProgramInfoEmbedded>
    {
        public override FontProgramInfoEmbedded Read(
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
            return new FontProgramInfoEmbedded(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontProgramInfoEmbedded value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontProgramInfoEmbedded ReadAsPropertyName(
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
            return new FontProgramInfoEmbedded(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontProgramInfoEmbedded value,
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
