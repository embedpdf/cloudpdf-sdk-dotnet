using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureAreaItemLabelPosition.DocPagesSetScaleRequestMeasureAreaItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureAreaItemLabelPosition : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureAreaItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly DocPagesSetScaleRequestMeasureAreaItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public DocPagesSetScaleRequestMeasureAreaItemLabelPosition(string value)
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
    public static DocPagesSetScaleRequestMeasureAreaItemLabelPosition FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureAreaItemLabelPosition(value);
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
        DocPagesSetScaleRequestMeasureAreaItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetScaleRequestMeasureAreaItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesSetScaleRequestMeasureAreaItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureAreaItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesSetScaleRequestMeasureAreaItemLabelPositionSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureAreaItemLabelPosition>
    {
        public override DocPagesSetScaleRequestMeasureAreaItemLabelPosition Read(
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
            return new DocPagesSetScaleRequestMeasureAreaItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureAreaItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureAreaItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureAreaItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureAreaItemLabelPosition value,
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
