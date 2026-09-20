using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureYItemLabelPosition.DocPagesSetScaleRequestMeasureYItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureYItemLabelPosition : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureYItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly DocPagesSetScaleRequestMeasureYItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public DocPagesSetScaleRequestMeasureYItemLabelPosition(string value)
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
    public static DocPagesSetScaleRequestMeasureYItemLabelPosition FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureYItemLabelPosition(value);
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
        DocPagesSetScaleRequestMeasureYItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetScaleRequestMeasureYItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesSetScaleRequestMeasureYItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureYItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesSetScaleRequestMeasureYItemLabelPositionSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureYItemLabelPosition>
    {
        public override DocPagesSetScaleRequestMeasureYItemLabelPosition Read(
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
            return new DocPagesSetScaleRequestMeasureYItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureYItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureYItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureYItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureYItemLabelPosition value,
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
