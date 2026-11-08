using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesSetScaleMeasureDistanceItemFraction.ChangeItemPagesSetScaleMeasureDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesSetScaleMeasureDistanceItemFraction : IStringEnum
{
    public static readonly ChangeItemPagesSetScaleMeasureDistanceItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeItemPagesSetScaleMeasureDistanceItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeItemPagesSetScaleMeasureDistanceItemFraction Round = new(
        Values.Round
    );

    public static readonly ChangeItemPagesSetScaleMeasureDistanceItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeItemPagesSetScaleMeasureDistanceItemFraction(string value)
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
    public static ChangeItemPagesSetScaleMeasureDistanceItemFraction FromCustom(string value)
    {
        return new ChangeItemPagesSetScaleMeasureDistanceItemFraction(value);
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
        ChangeItemPagesSetScaleMeasureDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesSetScaleMeasureDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ChangeItemPagesSetScaleMeasureDistanceItemFraction value
    ) => value.Value;

    public static explicit operator ChangeItemPagesSetScaleMeasureDistanceItemFraction(
        string value
    ) => new(value);

    internal class ChangeItemPagesSetScaleMeasureDistanceItemFractionSerializer
        : JsonConverter<ChangeItemPagesSetScaleMeasureDistanceItemFraction>
    {
        public override ChangeItemPagesSetScaleMeasureDistanceItemFraction Read(
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
            return new ChangeItemPagesSetScaleMeasureDistanceItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesSetScaleMeasureDistanceItemFraction ReadAsPropertyName(
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
            return new ChangeItemPagesSetScaleMeasureDistanceItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureDistanceItemFraction value,
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
