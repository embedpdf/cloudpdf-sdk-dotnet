using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfMeasurementRectilinearSlopeItemFraction.PdfMeasurementRectilinearSlopeItemFractionSerializer)
)]
[Serializable]
public readonly record struct PdfMeasurementRectilinearSlopeItemFraction : IStringEnum
{
    public static readonly PdfMeasurementRectilinearSlopeItemFraction Decimal = new(Values.Decimal);

    public static readonly PdfMeasurementRectilinearSlopeItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly PdfMeasurementRectilinearSlopeItemFraction Round = new(Values.Round);

    public static readonly PdfMeasurementRectilinearSlopeItemFraction Truncate = new(
        Values.Truncate
    );

    public PdfMeasurementRectilinearSlopeItemFraction(string value)
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
    public static PdfMeasurementRectilinearSlopeItemFraction FromCustom(string value)
    {
        return new PdfMeasurementRectilinearSlopeItemFraction(value);
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
        PdfMeasurementRectilinearSlopeItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PdfMeasurementRectilinearSlopeItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PdfMeasurementRectilinearSlopeItemFraction value) =>
        value.Value;

    public static explicit operator PdfMeasurementRectilinearSlopeItemFraction(string value) =>
        new(value);

    internal class PdfMeasurementRectilinearSlopeItemFractionSerializer
        : JsonConverter<PdfMeasurementRectilinearSlopeItemFraction>
    {
        public override PdfMeasurementRectilinearSlopeItemFraction Read(
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
            return new PdfMeasurementRectilinearSlopeItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearSlopeItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfMeasurementRectilinearSlopeItemFraction ReadAsPropertyName(
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
            return new PdfMeasurementRectilinearSlopeItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearSlopeItemFraction value,
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
