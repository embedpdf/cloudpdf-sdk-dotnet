using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition.DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition(
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
    public static DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition(
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
        DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPositionSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItemLabelPosition value,
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
