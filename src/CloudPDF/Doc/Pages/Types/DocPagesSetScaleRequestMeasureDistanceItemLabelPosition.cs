using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureDistanceItemLabelPosition.DocPagesSetScaleRequestMeasureDistanceItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureDistanceItemLabelPosition : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureDistanceItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly DocPagesSetScaleRequestMeasureDistanceItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public DocPagesSetScaleRequestMeasureDistanceItemLabelPosition(string value)
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
    public static DocPagesSetScaleRequestMeasureDistanceItemLabelPosition FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureDistanceItemLabelPosition(value);
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
        DocPagesSetScaleRequestMeasureDistanceItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetScaleRequestMeasureDistanceItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesSetScaleRequestMeasureDistanceItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureDistanceItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesSetScaleRequestMeasureDistanceItemLabelPositionSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureDistanceItemLabelPosition>
    {
        public override DocPagesSetScaleRequestMeasureDistanceItemLabelPosition Read(
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
            return new DocPagesSetScaleRequestMeasureDistanceItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureDistanceItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureDistanceItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureDistanceItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureDistanceItemLabelPosition value,
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
