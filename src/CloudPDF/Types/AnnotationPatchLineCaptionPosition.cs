using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchLineCaptionPosition.AnnotationPatchLineCaptionPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchLineCaptionPosition : IStringEnum
{
    public static readonly AnnotationPatchLineCaptionPosition Inline = new(Values.Inline);

    public static readonly AnnotationPatchLineCaptionPosition Top = new(Values.Top);

    public AnnotationPatchLineCaptionPosition(string value)
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
    public static AnnotationPatchLineCaptionPosition FromCustom(string value)
    {
        return new AnnotationPatchLineCaptionPosition(value);
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

    public static bool operator ==(AnnotationPatchLineCaptionPosition value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchLineCaptionPosition value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchLineCaptionPosition value) => value.Value;

    public static explicit operator AnnotationPatchLineCaptionPosition(string value) => new(value);

    internal class AnnotationPatchLineCaptionPositionSerializer
        : JsonConverter<AnnotationPatchLineCaptionPosition>
    {
        public override AnnotationPatchLineCaptionPosition Read(
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
            return new AnnotationPatchLineCaptionPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineCaptionPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineCaptionPosition ReadAsPropertyName(
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
            return new AnnotationPatchLineCaptionPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineCaptionPosition value,
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
        public const string Inline = "inline";

        public const string Top = "top";
    }
}
