using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition.DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition(string value)
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
    public static DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition(value);
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
        DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPositionSerializer
        : JsonConverter<DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition>
    {
        public override DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition Read(
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
            return new DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlAreaItemLabelPosition value,
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
