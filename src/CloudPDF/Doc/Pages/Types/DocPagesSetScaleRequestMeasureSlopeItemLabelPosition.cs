using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureSlopeItemLabelPosition.DocPagesSetScaleRequestMeasureSlopeItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureSlopeItemLabelPosition : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureSlopeItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly DocPagesSetScaleRequestMeasureSlopeItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public DocPagesSetScaleRequestMeasureSlopeItemLabelPosition(string value)
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
    public static DocPagesSetScaleRequestMeasureSlopeItemLabelPosition FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureSlopeItemLabelPosition(value);
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
        DocPagesSetScaleRequestMeasureSlopeItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetScaleRequestMeasureSlopeItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesSetScaleRequestMeasureSlopeItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureSlopeItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesSetScaleRequestMeasureSlopeItemLabelPositionSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureSlopeItemLabelPosition>
    {
        public override DocPagesSetScaleRequestMeasureSlopeItemLabelPosition Read(
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
            return new DocPagesSetScaleRequestMeasureSlopeItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureSlopeItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureSlopeItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureSlopeItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureSlopeItemLabelPosition value,
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
