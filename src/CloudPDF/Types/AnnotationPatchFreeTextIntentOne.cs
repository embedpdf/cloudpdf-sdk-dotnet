using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchFreeTextIntentOne.AnnotationPatchFreeTextIntentOneSerializer))]
[Serializable]
public readonly record struct AnnotationPatchFreeTextIntentOne : IStringEnum
{
    public static readonly AnnotationPatchFreeTextIntentOne FreeText = new(Values.FreeText);

    public static readonly AnnotationPatchFreeTextIntentOne FreeTextCallout = new(
        Values.FreeTextCallout
    );

    public static readonly AnnotationPatchFreeTextIntentOne FreeTextTypewriter = new(
        Values.FreeTextTypewriter
    );

    public AnnotationPatchFreeTextIntentOne(string value)
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
    public static AnnotationPatchFreeTextIntentOne FromCustom(string value)
    {
        return new AnnotationPatchFreeTextIntentOne(value);
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

    public static bool operator ==(AnnotationPatchFreeTextIntentOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchFreeTextIntentOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFreeTextIntentOne value) => value.Value;

    public static explicit operator AnnotationPatchFreeTextIntentOne(string value) => new(value);

    internal class AnnotationPatchFreeTextIntentOneSerializer
        : JsonConverter<AnnotationPatchFreeTextIntentOne>
    {
        public override AnnotationPatchFreeTextIntentOne Read(
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
            return new AnnotationPatchFreeTextIntentOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextIntentOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextIntentOne ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextIntentOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextIntentOne value,
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
