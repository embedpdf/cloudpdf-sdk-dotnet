using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesSetScaleMeasureAngleItemFraction.ChangeItemPagesSetScaleMeasureAngleItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesSetScaleMeasureAngleItemFraction : IStringEnum
{
    public static readonly ChangeItemPagesSetScaleMeasureAngleItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeItemPagesSetScaleMeasureAngleItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeItemPagesSetScaleMeasureAngleItemFraction Round = new(
        Values.Round
    );

    public static readonly ChangeItemPagesSetScaleMeasureAngleItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeItemPagesSetScaleMeasureAngleItemFraction(string value)
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
    public static ChangeItemPagesSetScaleMeasureAngleItemFraction FromCustom(string value)
    {
        return new ChangeItemPagesSetScaleMeasureAngleItemFraction(value);
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
        ChangeItemPagesSetScaleMeasureAngleItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesSetScaleMeasureAngleItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesSetScaleMeasureAngleItemFraction value) =>
        value.Value;

    public static explicit operator ChangeItemPagesSetScaleMeasureAngleItemFraction(string value) =>
        new(value);

    internal class ChangeItemPagesSetScaleMeasureAngleItemFractionSerializer
        : JsonConverter<ChangeItemPagesSetScaleMeasureAngleItemFraction>
    {
        public override ChangeItemPagesSetScaleMeasureAngleItemFraction Read(
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
            return new ChangeItemPagesSetScaleMeasureAngleItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureAngleItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesSetScaleMeasureAngleItemFraction ReadAsPropertyName(
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
            return new ChangeItemPagesSetScaleMeasureAngleItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureAngleItemFraction value,
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
