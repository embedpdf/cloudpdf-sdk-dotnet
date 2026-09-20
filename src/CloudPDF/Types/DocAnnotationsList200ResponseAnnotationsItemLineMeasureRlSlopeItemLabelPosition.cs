using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition(
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
    public static DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition(
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
        DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPositionSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItemLabelPosition value,
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
