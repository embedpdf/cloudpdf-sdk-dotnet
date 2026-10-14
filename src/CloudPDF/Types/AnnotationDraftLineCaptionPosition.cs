using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftLineCaptionPosition.AnnotationDraftLineCaptionPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftLineCaptionPosition : IStringEnum
{
    public static readonly AnnotationDraftLineCaptionPosition Inline = new(Values.Inline);

    public static readonly AnnotationDraftLineCaptionPosition Top = new(Values.Top);

    public AnnotationDraftLineCaptionPosition(string value)
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
    public static AnnotationDraftLineCaptionPosition FromCustom(string value)
    {
        return new AnnotationDraftLineCaptionPosition(value);
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

    public static bool operator ==(AnnotationDraftLineCaptionPosition value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftLineCaptionPosition value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftLineCaptionPosition value) => value.Value;

    public static explicit operator AnnotationDraftLineCaptionPosition(string value) => new(value);

    internal class AnnotationDraftLineCaptionPositionSerializer
        : JsonConverter<AnnotationDraftLineCaptionPosition>
    {
        public override AnnotationDraftLineCaptionPosition Read(
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
            return new AnnotationDraftLineCaptionPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLineCaptionPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLineCaptionPosition ReadAsPropertyName(
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
            return new AnnotationDraftLineCaptionPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLineCaptionPosition value,
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
