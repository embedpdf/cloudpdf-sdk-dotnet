using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition(
        string value
    )
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
    public static DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition(
            value
        );
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
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPositionSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItemLabelPosition value,
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
        public const string Suffix = "suffix";

        public const string Prefix = "prefix";
    }
}
