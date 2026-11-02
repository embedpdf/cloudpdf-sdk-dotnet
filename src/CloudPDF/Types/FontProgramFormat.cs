using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FontProgramFormat.FontProgramFormatSerializer))]
[Serializable]
public readonly record struct FontProgramFormat : IStringEnum
{
    public static readonly FontProgramFormat Truetype = new(Values.Truetype);

    public static readonly FontProgramFormat Opentype = new(Values.Opentype);

    public static readonly FontProgramFormat Cff = new(Values.Cff);

    public static readonly FontProgramFormat Type1 = new(Values.Type1);

    public static readonly FontProgramFormat Type3 = new(Values.Type3);

    public FontProgramFormat(string value)
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
    public static FontProgramFormat FromCustom(string value)
    {
        return new FontProgramFormat(value);
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

    public static bool operator ==(FontProgramFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FontProgramFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontProgramFormat value) => value.Value;

    public static explicit operator FontProgramFormat(string value) => new(value);

    internal class FontProgramFormatSerializer : JsonConverter<FontProgramFormat>
    {
        public override FontProgramFormat Read(
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
            return new FontProgramFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontProgramFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontProgramFormat ReadAsPropertyName(
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
            return new FontProgramFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontProgramFormat value,
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
