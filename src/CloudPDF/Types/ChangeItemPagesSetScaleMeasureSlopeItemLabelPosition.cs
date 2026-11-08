using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition.ChangeItemPagesSetScaleMeasureSlopeItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition : IStringEnum
{
    public static readonly ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition(string value)
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
    public static ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition FromCustom(string value)
    {
        return new ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition(value);
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
        ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition value
    ) => value.Value;

    public static explicit operator ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition(
        string value
    ) => new(value);

    internal class ChangeItemPagesSetScaleMeasureSlopeItemLabelPositionSerializer
        : JsonConverter<ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition>
    {
        public override ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition Read(
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
            return new ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition ReadAsPropertyName(
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
            return new ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureSlopeItemLabelPosition value,
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
