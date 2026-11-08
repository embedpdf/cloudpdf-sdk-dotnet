using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeOpPagesSetScaleMeasureYItemFraction.ChangeOpPagesSetScaleMeasureYItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeOpPagesSetScaleMeasureYItemFraction : IStringEnum
{
    public static readonly ChangeOpPagesSetScaleMeasureYItemFraction Decimal = new(Values.Decimal);

    public static readonly ChangeOpPagesSetScaleMeasureYItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeOpPagesSetScaleMeasureYItemFraction Round = new(Values.Round);

    public static readonly ChangeOpPagesSetScaleMeasureYItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeOpPagesSetScaleMeasureYItemFraction(string value)
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
    public static ChangeOpPagesSetScaleMeasureYItemFraction FromCustom(string value)
    {
        return new ChangeOpPagesSetScaleMeasureYItemFraction(value);
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
        ChangeOpPagesSetScaleMeasureYItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeOpPagesSetScaleMeasureYItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeOpPagesSetScaleMeasureYItemFraction value) =>
        value.Value;

    public static explicit operator ChangeOpPagesSetScaleMeasureYItemFraction(string value) =>
        new(value);

    internal class ChangeOpPagesSetScaleMeasureYItemFractionSerializer
        : JsonConverter<ChangeOpPagesSetScaleMeasureYItemFraction>
    {
        public override ChangeOpPagesSetScaleMeasureYItemFraction Read(
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
            return new ChangeOpPagesSetScaleMeasureYItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureYItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpPagesSetScaleMeasureYItemFraction ReadAsPropertyName(
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
            return new ChangeOpPagesSetScaleMeasureYItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureYItemFraction value,
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
