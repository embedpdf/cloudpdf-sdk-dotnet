using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationInkIntent.AnnotationInkIntentSerializer))]
[Serializable]
public readonly record struct AnnotationInkIntent : IStringEnum
{
    public static readonly AnnotationInkIntent InkHighlight = new(Values.InkHighlight);

    public AnnotationInkIntent(string value)
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
    public static AnnotationInkIntent FromCustom(string value)
    {
        return new AnnotationInkIntent(value);
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

    public static bool operator ==(AnnotationInkIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationInkIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationInkIntent value) => value.Value;

    public static explicit operator AnnotationInkIntent(string value) => new(value);

    internal class AnnotationInkIntentSerializer : JsonConverter<AnnotationInkIntent>
    {
        public override AnnotationInkIntent Read(
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
            return new AnnotationInkIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationInkIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationInkIntent ReadAsPropertyName(
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
            return new AnnotationInkIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationInkIntent value,
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
        public const string InkHighlight = "ink-highlight";
    }
}
