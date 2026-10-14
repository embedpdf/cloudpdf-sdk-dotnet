using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchInkIntent.AnnotationPatchInkIntentSerializer))]
[Serializable]
public readonly record struct AnnotationPatchInkIntent : IStringEnum
{
    public static readonly AnnotationPatchInkIntent InkHighlight = new(Values.InkHighlight);

    public AnnotationPatchInkIntent(string value)
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
    public static AnnotationPatchInkIntent FromCustom(string value)
    {
        return new AnnotationPatchInkIntent(value);
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

    public static bool operator ==(AnnotationPatchInkIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchInkIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchInkIntent value) => value.Value;

    public static explicit operator AnnotationPatchInkIntent(string value) => new(value);

    internal class AnnotationPatchInkIntentSerializer : JsonConverter<AnnotationPatchInkIntent>
    {
        public override AnnotationPatchInkIntent Read(
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
            return new AnnotationPatchInkIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchInkIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchInkIntent ReadAsPropertyName(
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
            return new AnnotationPatchInkIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchInkIntent value,
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
