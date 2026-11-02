using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FontProgramInfoFormat.FontProgramInfoFormatSerializer))]
[Serializable]
public readonly record struct FontProgramInfoFormat : IStringEnum
{
    public static readonly FontProgramInfoFormat Truetype = new(Values.Truetype);

    public static readonly FontProgramInfoFormat Opentype = new(Values.Opentype);

    public static readonly FontProgramInfoFormat Cff = new(Values.Cff);

    public static readonly FontProgramInfoFormat Type1 = new(Values.Type1);

    public static readonly FontProgramInfoFormat Type3 = new(Values.Type3);

    public FontProgramInfoFormat(string value)
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
    public static FontProgramInfoFormat FromCustom(string value)
    {
        return new FontProgramInfoFormat(value);
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

    public static bool operator ==(FontProgramInfoFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FontProgramInfoFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontProgramInfoFormat value) => value.Value;

    public static explicit operator FontProgramInfoFormat(string value) => new(value);

    internal class FontProgramInfoFormatSerializer : JsonConverter<FontProgramInfoFormat>
    {
        public override FontProgramInfoFormat Read(
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
            return new FontProgramInfoFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontProgramInfoFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontProgramInfoFormat ReadAsPropertyName(
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
            return new FontProgramInfoFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontProgramInfoFormat value,
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
        public const string Truetype = "truetype";

        public const string Opentype = "opentype";

        public const string Cff = "cff";

        public const string Type1 = "type1";

        public const string Type3 = "type3";
    }
}
