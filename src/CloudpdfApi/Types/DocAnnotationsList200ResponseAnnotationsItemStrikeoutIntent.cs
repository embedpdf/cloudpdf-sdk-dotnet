using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent.DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntentSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent StrikeoutTextEdit =
        new(Values.StrikeoutTextEdit);

    public DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent(value);
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

    public static bool operator ==(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntentSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStrikeoutIntent value,
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
