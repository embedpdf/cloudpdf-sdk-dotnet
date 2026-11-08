using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesSetScaleMeasureYItemFraction.ChangeItemPagesSetScaleMeasureYItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesSetScaleMeasureYItemFraction : IStringEnum
{
    public static readonly ChangeItemPagesSetScaleMeasureYItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeItemPagesSetScaleMeasureYItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeItemPagesSetScaleMeasureYItemFraction Round = new(Values.Round);

    public static readonly ChangeItemPagesSetScaleMeasureYItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeItemPagesSetScaleMeasureYItemFraction(string value)
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
    public static ChangeItemPagesSetScaleMeasureYItemFraction FromCustom(string value)
    {
        return new ChangeItemPagesSetScaleMeasureYItemFraction(value);
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
        ChangeItemPagesSetScaleMeasureYItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesSetScaleMeasureYItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesSetScaleMeasureYItemFraction value) =>
        value.Value;

    public static explicit operator ChangeItemPagesSetScaleMeasureYItemFraction(string value) =>
        new(value);

    internal class ChangeItemPagesSetScaleMeasureYItemFractionSerializer
        : JsonConverter<ChangeItemPagesSetScaleMeasureYItemFraction>
    {
        public override ChangeItemPagesSetScaleMeasureYItemFraction Read(
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
            return new ChangeItemPagesSetScaleMeasureYItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureYItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesSetScaleMeasureYItemFraction ReadAsPropertyName(
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
            return new ChangeItemPagesSetScaleMeasureYItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureYItemFraction value,
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
