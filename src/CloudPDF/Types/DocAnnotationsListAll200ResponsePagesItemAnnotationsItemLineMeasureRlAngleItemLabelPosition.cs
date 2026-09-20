using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPositionSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItemLabelPosition value,
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
