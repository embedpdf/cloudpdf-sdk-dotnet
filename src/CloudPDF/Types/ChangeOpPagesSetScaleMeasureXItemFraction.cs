using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeOpPagesSetScaleMeasureXItemFraction.ChangeOpPagesSetScaleMeasureXItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeOpPagesSetScaleMeasureXItemFraction : IStringEnum
{
    public static readonly ChangeOpPagesSetScaleMeasureXItemFraction Decimal = new(Values.Decimal);

    public static readonly ChangeOpPagesSetScaleMeasureXItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeOpPagesSetScaleMeasureXItemFraction Round = new(Values.Round);

    public static readonly ChangeOpPagesSetScaleMeasureXItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeOpPagesSetScaleMeasureXItemFraction(string value)
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
    public static ChangeOpPagesSetScaleMeasureXItemFraction FromCustom(string value)
    {
        return new ChangeOpPagesSetScaleMeasureXItemFraction(value);
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
        ChangeOpPagesSetScaleMeasureXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeOpPagesSetScaleMeasureXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeOpPagesSetScaleMeasureXItemFraction value) =>
        value.Value;

    public static explicit operator ChangeOpPagesSetScaleMeasureXItemFraction(string value) =>
        new(value);

    internal class ChangeOpPagesSetScaleMeasureXItemFractionSerializer
        : JsonConverter<ChangeOpPagesSetScaleMeasureXItemFraction>
    {
        public override ChangeOpPagesSetScaleMeasureXItemFraction Read(
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
            return new ChangeOpPagesSetScaleMeasureXItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpPagesSetScaleMeasureXItemFraction ReadAsPropertyName(
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
            return new ChangeOpPagesSetScaleMeasureXItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureXItemFraction value,
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
