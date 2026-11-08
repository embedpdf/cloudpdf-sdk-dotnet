using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeOpPagesSetScaleMeasureDistanceItemFraction.ChangeOpPagesSetScaleMeasureDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeOpPagesSetScaleMeasureDistanceItemFraction : IStringEnum
{
    public static readonly ChangeOpPagesSetScaleMeasureDistanceItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeOpPagesSetScaleMeasureDistanceItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeOpPagesSetScaleMeasureDistanceItemFraction Round = new(
        Values.Round
    );

    public static readonly ChangeOpPagesSetScaleMeasureDistanceItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeOpPagesSetScaleMeasureDistanceItemFraction(string value)
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
    public static ChangeOpPagesSetScaleMeasureDistanceItemFraction FromCustom(string value)
    {
        return new ChangeOpPagesSetScaleMeasureDistanceItemFraction(value);
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
        ChangeOpPagesSetScaleMeasureDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeOpPagesSetScaleMeasureDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ChangeOpPagesSetScaleMeasureDistanceItemFraction value
    ) => value.Value;

    public static explicit operator ChangeOpPagesSetScaleMeasureDistanceItemFraction(
        string value
    ) => new(value);

    internal class ChangeOpPagesSetScaleMeasureDistanceItemFractionSerializer
        : JsonConverter<ChangeOpPagesSetScaleMeasureDistanceItemFraction>
    {
        public override ChangeOpPagesSetScaleMeasureDistanceItemFraction Read(
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
            return new ChangeOpPagesSetScaleMeasureDistanceItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpPagesSetScaleMeasureDistanceItemFraction ReadAsPropertyName(
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
            return new ChangeOpPagesSetScaleMeasureDistanceItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureDistanceItemFraction value,
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
        public const string Decimal = "decimal";

        public const string Fraction = "fraction";

        public const string Round = "round";

        public const string Truncate = "truncate";
    }
}
