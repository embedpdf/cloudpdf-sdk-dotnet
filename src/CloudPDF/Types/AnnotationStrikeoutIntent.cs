using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationStrikeoutIntent.AnnotationStrikeoutIntentSerializer))]
[Serializable]
public readonly record struct AnnotationStrikeoutIntent : IStringEnum
{
    public static readonly AnnotationStrikeoutIntent StrikeoutTextEdit = new(
        Values.StrikeoutTextEdit
    );

    public AnnotationStrikeoutIntent(string value)
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
    public static AnnotationStrikeoutIntent FromCustom(string value)
    {
        return new AnnotationStrikeoutIntent(value);
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

    public static bool operator ==(AnnotationStrikeoutIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationStrikeoutIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationStrikeoutIntent value) => value.Value;

    public static explicit operator AnnotationStrikeoutIntent(string value) => new(value);

    internal class AnnotationStrikeoutIntentSerializer : JsonConverter<AnnotationStrikeoutIntent>
    {
        public override AnnotationStrikeoutIntent Read(
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
            return new AnnotationStrikeoutIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationStrikeoutIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationStrikeoutIntent ReadAsPropertyName(
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
            return new AnnotationStrikeoutIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationStrikeoutIntent value,
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
