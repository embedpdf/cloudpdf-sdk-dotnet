using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition.DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition(string value)
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
    public static DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition(value);
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
        DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPositionSerializer
        : JsonConverter<DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition>
    {
        public override DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition Read(
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
            return new DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlDistanceItemLabelPosition value,
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
