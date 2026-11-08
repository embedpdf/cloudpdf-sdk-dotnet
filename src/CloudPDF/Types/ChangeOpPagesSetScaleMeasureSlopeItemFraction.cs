using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeOpPagesSetScaleMeasureSlopeItemFraction.ChangeOpPagesSetScaleMeasureSlopeItemFractionSerializer)
)]
[Serializable]
public readonly record struct ChangeOpPagesSetScaleMeasureSlopeItemFraction : IStringEnum
{
    public static readonly ChangeOpPagesSetScaleMeasureSlopeItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeOpPagesSetScaleMeasureSlopeItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly ChangeOpPagesSetScaleMeasureSlopeItemFraction Round = new(Values.Round);

    public static readonly ChangeOpPagesSetScaleMeasureSlopeItemFraction Truncate = new(
        Values.Truncate
    );

    public ChangeOpPagesSetScaleMeasureSlopeItemFraction(string value)
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
    public static ChangeOpPagesSetScaleMeasureSlopeItemFraction FromCustom(string value)
    {
        return new ChangeOpPagesSetScaleMeasureSlopeItemFraction(value);
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
        ChangeOpPagesSetScaleMeasureSlopeItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeOpPagesSetScaleMeasureSlopeItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeOpPagesSetScaleMeasureSlopeItemFraction value) =>
        value.Value;

    public static explicit operator ChangeOpPagesSetScaleMeasureSlopeItemFraction(string value) =>
        new(value);

    internal class ChangeOpPagesSetScaleMeasureSlopeItemFractionSerializer
        : JsonConverter<ChangeOpPagesSetScaleMeasureSlopeItemFraction>
    {
        public override ChangeOpPagesSetScaleMeasureSlopeItemFraction Read(
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
            return new ChangeOpPagesSetScaleMeasureSlopeItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureSlopeItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpPagesSetScaleMeasureSlopeItemFraction ReadAsPropertyName(
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
            return new ChangeOpPagesSetScaleMeasureSlopeItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureSlopeItemFraction value,
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
