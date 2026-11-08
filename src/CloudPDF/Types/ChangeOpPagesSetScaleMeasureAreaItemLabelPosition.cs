using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeOpPagesSetScaleMeasureAreaItemLabelPosition.ChangeOpPagesSetScaleMeasureAreaItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct ChangeOpPagesSetScaleMeasureAreaItemLabelPosition : IStringEnum
{
    public static readonly ChangeOpPagesSetScaleMeasureAreaItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly ChangeOpPagesSetScaleMeasureAreaItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public ChangeOpPagesSetScaleMeasureAreaItemLabelPosition(string value)
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
    public static ChangeOpPagesSetScaleMeasureAreaItemLabelPosition FromCustom(string value)
    {
        return new ChangeOpPagesSetScaleMeasureAreaItemLabelPosition(value);
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
        ChangeOpPagesSetScaleMeasureAreaItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeOpPagesSetScaleMeasureAreaItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ChangeOpPagesSetScaleMeasureAreaItemLabelPosition value
    ) => value.Value;

    public static explicit operator ChangeOpPagesSetScaleMeasureAreaItemLabelPosition(
        string value
    ) => new(value);

    internal class ChangeOpPagesSetScaleMeasureAreaItemLabelPositionSerializer
        : JsonConverter<ChangeOpPagesSetScaleMeasureAreaItemLabelPosition>
    {
        public override ChangeOpPagesSetScaleMeasureAreaItemLabelPosition Read(
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
            return new ChangeOpPagesSetScaleMeasureAreaItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureAreaItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpPagesSetScaleMeasureAreaItemLabelPosition ReadAsPropertyName(
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
            return new ChangeOpPagesSetScaleMeasureAreaItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureAreaItemLabelPosition value,
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
