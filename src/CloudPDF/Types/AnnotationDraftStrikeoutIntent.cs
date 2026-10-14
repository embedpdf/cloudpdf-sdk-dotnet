using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftStrikeoutIntent.AnnotationDraftStrikeoutIntentSerializer))]
[Serializable]
public readonly record struct AnnotationDraftStrikeoutIntent : IStringEnum
{
    public static readonly AnnotationDraftStrikeoutIntent StrikeoutTextEdit = new(
        Values.StrikeoutTextEdit
    );

    public AnnotationDraftStrikeoutIntent(string value)
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
    public static AnnotationDraftStrikeoutIntent FromCustom(string value)
    {
        return new AnnotationDraftStrikeoutIntent(value);
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

    public static bool operator ==(AnnotationDraftStrikeoutIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftStrikeoutIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftStrikeoutIntent value) => value.Value;

    public static explicit operator AnnotationDraftStrikeoutIntent(string value) => new(value);

    internal class AnnotationDraftStrikeoutIntentSerializer
        : JsonConverter<AnnotationDraftStrikeoutIntent>
    {
        public override AnnotationDraftStrikeoutIntent Read(
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
            return new AnnotationDraftStrikeoutIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftStrikeoutIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftStrikeoutIntent ReadAsPropertyName(
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
            return new AnnotationDraftStrikeoutIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftStrikeoutIntent value,
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
        public const string StrikeoutTextEdit = "strikeout-text-edit";
    }
}
