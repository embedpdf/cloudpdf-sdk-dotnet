using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesSetScaleMeasureAngleItemLabelPosition.ChangeItemPagesSetScaleMeasureAngleItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesSetScaleMeasureAngleItemLabelPosition : IStringEnum
{
    public static readonly ChangeItemPagesSetScaleMeasureAngleItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly ChangeItemPagesSetScaleMeasureAngleItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public ChangeItemPagesSetScaleMeasureAngleItemLabelPosition(string value)
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
    public static ChangeItemPagesSetScaleMeasureAngleItemLabelPosition FromCustom(string value)
    {
        return new ChangeItemPagesSetScaleMeasureAngleItemLabelPosition(value);
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
        ChangeItemPagesSetScaleMeasureAngleItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesSetScaleMeasureAngleItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ChangeItemPagesSetScaleMeasureAngleItemLabelPosition value
    ) => value.Value;

    public static explicit operator ChangeItemPagesSetScaleMeasureAngleItemLabelPosition(
        string value
    ) => new(value);

    internal class ChangeItemPagesSetScaleMeasureAngleItemLabelPositionSerializer
        : JsonConverter<ChangeItemPagesSetScaleMeasureAngleItemLabelPosition>
    {
        public override ChangeItemPagesSetScaleMeasureAngleItemLabelPosition Read(
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
            return new ChangeItemPagesSetScaleMeasureAngleItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureAngleItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesSetScaleMeasureAngleItemLabelPosition ReadAsPropertyName(
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
            return new ChangeItemPagesSetScaleMeasureAngleItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureAngleItemLabelPosition value,
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
