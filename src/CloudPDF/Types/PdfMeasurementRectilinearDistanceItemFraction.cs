using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfMeasurementRectilinearDistanceItemFraction.PdfMeasurementRectilinearDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct PdfMeasurementRectilinearDistanceItemFraction : IStringEnum
{
    public static readonly PdfMeasurementRectilinearDistanceItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly PdfMeasurementRectilinearDistanceItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly PdfMeasurementRectilinearDistanceItemFraction Round = new(Values.Round);

    public static readonly PdfMeasurementRectilinearDistanceItemFraction Truncate = new(
        Values.Truncate
    );

    public PdfMeasurementRectilinearDistanceItemFraction(string value)
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
    public static PdfMeasurementRectilinearDistanceItemFraction FromCustom(string value)
    {
        return new PdfMeasurementRectilinearDistanceItemFraction(value);
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
        PdfMeasurementRectilinearDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PdfMeasurementRectilinearDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PdfMeasurementRectilinearDistanceItemFraction value) =>
        value.Value;

    public static explicit operator PdfMeasurementRectilinearDistanceItemFraction(string value) =>
        new(value);

    internal class PdfMeasurementRectilinearDistanceItemFractionSerializer
        : JsonConverter<PdfMeasurementRectilinearDistanceItemFraction>
    {
        public override PdfMeasurementRectilinearDistanceItemFraction Read(
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
            return new PdfMeasurementRectilinearDistanceItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfMeasurementRectilinearDistanceItemFraction ReadAsPropertyName(
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
            return new PdfMeasurementRectilinearDistanceItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearDistanceItemFraction value,
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
