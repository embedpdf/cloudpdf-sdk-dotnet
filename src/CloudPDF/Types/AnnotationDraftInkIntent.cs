using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftInkIntent.AnnotationDraftInkIntentSerializer))]
[Serializable]
public readonly record struct AnnotationDraftInkIntent : IStringEnum
{
    public static readonly AnnotationDraftInkIntent InkHighlight = new(Values.InkHighlight);

    public AnnotationDraftInkIntent(string value)
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
    public static AnnotationDraftInkIntent FromCustom(string value)
    {
        return new AnnotationDraftInkIntent(value);
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

    public static bool operator ==(AnnotationDraftInkIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftInkIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftInkIntent value) => value.Value;

    public static explicit operator AnnotationDraftInkIntent(string value) => new(value);

    internal class AnnotationDraftInkIntentSerializer : JsonConverter<AnnotationDraftInkIntent>
    {
        public override AnnotationDraftInkIntent Read(
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
            return new AnnotationDraftInkIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftInkIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftInkIntent ReadAsPropertyName(
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
            return new AnnotationDraftInkIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftInkIntent value,
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
