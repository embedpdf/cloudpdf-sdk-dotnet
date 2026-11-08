using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition.ChangeOpPagesSetScaleMeasureDistanceItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition : IStringEnum
{
    public static readonly ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition(string value)
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
    public static ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition FromCustom(string value)
    {
        return new ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition(value);
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
        ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition value
    ) => value.Value;

    public static explicit operator ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition(
        string value
    ) => new(value);

    internal class ChangeOpPagesSetScaleMeasureDistanceItemLabelPositionSerializer
        : JsonConverter<ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition>
    {
        public override ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition Read(
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
            return new ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition ReadAsPropertyName(
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
            return new ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureDistanceItemLabelPosition value,
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
