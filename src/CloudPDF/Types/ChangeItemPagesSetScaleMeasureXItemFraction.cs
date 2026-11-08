using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesSetScaleMeasureXItemFraction.ChangeItemPagesSetScaleMeasureXItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesSetScaleMeasureXItemFraction : IStringEnum
{
    public static readonly ChangeItemPagesSetScaleMeasureXItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeItemPagesSetScaleMeasureXItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeItemPagesSetScaleMeasureXItemFraction Round = new(Values.Round);

    public static readonly ChangeItemPagesSetScaleMeasureXItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeItemPagesSetScaleMeasureXItemFraction(string value)
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
    public static ChangeItemPagesSetScaleMeasureXItemFraction FromCustom(string value)
    {
        return new ChangeItemPagesSetScaleMeasureXItemFraction(value);
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
        ChangeItemPagesSetScaleMeasureXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesSetScaleMeasureXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesSetScaleMeasureXItemFraction value) =>
        value.Value;

    public static explicit operator ChangeItemPagesSetScaleMeasureXItemFraction(string value) =>
        new(value);

    internal class ChangeItemPagesSetScaleMeasureXItemFractionSerializer
        : JsonConverter<ChangeItemPagesSetScaleMeasureXItemFraction>
    {
        public override ChangeItemPagesSetScaleMeasureXItemFraction Read(
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
            return new ChangeItemPagesSetScaleMeasureXItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesSetScaleMeasureXItemFraction ReadAsPropertyName(
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
            return new ChangeItemPagesSetScaleMeasureXItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureXItemFraction value,
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
