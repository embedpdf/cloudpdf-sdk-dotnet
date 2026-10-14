using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationFreeTextIntent.AnnotationFreeTextIntentSerializer))]
[Serializable]
public readonly record struct AnnotationFreeTextIntent : IStringEnum
{
    public static readonly AnnotationFreeTextIntent FreeText = new(Values.FreeText);

    public static readonly AnnotationFreeTextIntent FreeTextCallout = new(Values.FreeTextCallout);

    public static readonly AnnotationFreeTextIntent FreeTextTypewriter = new(
        Values.FreeTextTypewriter
    );

    public AnnotationFreeTextIntent(string value)
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
    public static AnnotationFreeTextIntent FromCustom(string value)
    {
        return new AnnotationFreeTextIntent(value);
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

    public static bool operator ==(AnnotationFreeTextIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFreeTextIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextIntent value) => value.Value;

    public static explicit operator AnnotationFreeTextIntent(string value) => new(value);

    internal class AnnotationFreeTextIntentSerializer : JsonConverter<AnnotationFreeTextIntent>
    {
        public override AnnotationFreeTextIntent Read(
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
            return new AnnotationFreeTextIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextIntent ReadAsPropertyName(
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
            return new AnnotationFreeTextIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextIntent value,
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
        public const string FreeText = "free-text";

        public const string FreeTextCallout = "free-text-callout";

        public const string FreeTextTypewriter = "free-text-typewriter";
    }
}
