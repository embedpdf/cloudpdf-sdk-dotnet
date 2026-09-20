using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition.DocPagesViewports200ResponseItemMeasureRlYItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition(string value)
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
    public static DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition(value);
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
        DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseItemMeasureRlYItemLabelPositionSerializer
        : JsonConverter<DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition>
    {
        public override DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition Read(
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
            return new DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlYItemLabelPosition value,
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
