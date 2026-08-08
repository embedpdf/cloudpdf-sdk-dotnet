using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemInkIntent.DocAnnotationsList200ResponseAnnotationsItemInkIntentSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemInkIntent : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemInkIntent InkHighlight = new(
        Values.InkHighlight
    );

    public DocAnnotationsList200ResponseAnnotationsItemInkIntent(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemInkIntent FromCustom(string value)
    {
        return new DocAnnotationsList200ResponseAnnotationsItemInkIntent(value);
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
        DocAnnotationsList200ResponseAnnotationsItemInkIntent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemInkIntent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemInkIntent value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemInkIntent(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemInkIntentSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemInkIntent>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemInkIntent Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemInkIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemInkIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemInkIntent ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemInkIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemInkIntent value,
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
