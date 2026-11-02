using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FontRestrictionsItem.FontRestrictionsItemSerializer))]
[Serializable]
public readonly record struct FontRestrictionsItem : IStringEnum
{
    public static readonly FontRestrictionsItem Subset = new(Values.Subset);

    public static readonly FontRestrictionsItem NotEmbedded = new(Values.NotEmbedded);

    public static readonly FontRestrictionsItem PreviewAndPrint = new(Values.PreviewAndPrint);

    public static readonly FontRestrictionsItem UnsupportedFormat = new(Values.UnsupportedFormat);

    public static readonly FontRestrictionsItem NoUnicodeMap = new(Values.NoUnicodeMap);

    public static readonly FontRestrictionsItem NotServed = new(Values.NotServed);

    public FontRestrictionsItem(string value)
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
    public static FontRestrictionsItem FromCustom(string value)
    {
        return new FontRestrictionsItem(value);
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

    public static bool operator ==(FontRestrictionsItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FontRestrictionsItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontRestrictionsItem value) => value.Value;

    public static explicit operator FontRestrictionsItem(string value) => new(value);

    internal class FontRestrictionsItemSerializer : JsonConverter<FontRestrictionsItem>
    {
        public override FontRestrictionsItem Read(
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
            return new FontRestrictionsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontRestrictionsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontRestrictionsItem ReadAsPropertyName(
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
            return new FontRestrictionsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontRestrictionsItem value,
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
        public const string Subset = "subset";

        public const string NotEmbedded = "not-embedded";

        public const string PreviewAndPrint = "preview-and-print";

        public const string UnsupportedFormat = "unsupported-format";

        public const string NoUnicodeMap = "no-unicode-map";

        public const string NotServed = "not-served";
    }
}
