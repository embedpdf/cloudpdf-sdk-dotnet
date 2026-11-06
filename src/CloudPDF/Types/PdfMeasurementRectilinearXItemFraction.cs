using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfMeasurementRectilinearXItemFraction.PdfMeasurementRectilinearXItemFractionSerializer)
)]
[Serializable]
public readonly record struct PdfMeasurementRectilinearXItemFraction : IStringEnum
{
    public static readonly PdfMeasurementRectilinearXItemFraction Decimal = new(Values.Decimal);

    public static readonly PdfMeasurementRectilinearXItemFraction Fraction = new(Values.Fraction);

    public static readonly PdfMeasurementRectilinearXItemFraction Round = new(Values.Round);

    public static readonly PdfMeasurementRectilinearXItemFraction Truncate = new(Values.Truncate);

    public PdfMeasurementRectilinearXItemFraction(string value)
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
    public static PdfMeasurementRectilinearXItemFraction FromCustom(string value)
    {
        return new PdfMeasurementRectilinearXItemFraction(value);
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

    public static bool operator ==(PdfMeasurementRectilinearXItemFraction value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfMeasurementRectilinearXItemFraction value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfMeasurementRectilinearXItemFraction value) =>
        value.Value;

    public static explicit operator PdfMeasurementRectilinearXItemFraction(string value) =>
        new(value);

    internal class PdfMeasurementRectilinearXItemFractionSerializer
        : JsonConverter<PdfMeasurementRectilinearXItemFraction>
    {
        public override PdfMeasurementRectilinearXItemFraction Read(
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
            return new PdfMeasurementRectilinearXItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfMeasurementRectilinearXItemFraction ReadAsPropertyName(
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
            return new PdfMeasurementRectilinearXItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearXItemFraction value,
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
