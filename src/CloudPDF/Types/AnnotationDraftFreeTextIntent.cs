using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftFreeTextIntent.AnnotationDraftFreeTextIntentSerializer))]
[Serializable]
public readonly record struct AnnotationDraftFreeTextIntent : IStringEnum
{
    public static readonly AnnotationDraftFreeTextIntent FreeText = new(Values.FreeText);

    public static readonly AnnotationDraftFreeTextIntent FreeTextCallout = new(
        Values.FreeTextCallout
    );

    public AnnotationDraftFreeTextIntent(string value)
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
    public static AnnotationDraftFreeTextIntent FromCustom(string value)
    {
        return new AnnotationDraftFreeTextIntent(value);
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

    public static bool operator ==(AnnotationDraftFreeTextIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftFreeTextIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFreeTextIntent value) => value.Value;

    public static explicit operator AnnotationDraftFreeTextIntent(string value) => new(value);

    internal class AnnotationDraftFreeTextIntentSerializer
        : JsonConverter<AnnotationDraftFreeTextIntent>
    {
        public override AnnotationDraftFreeTextIntent Read(
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
            return new AnnotationDraftFreeTextIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFreeTextIntent ReadAsPropertyName(
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
            return new AnnotationDraftFreeTextIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextIntent value,
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
    }
}
