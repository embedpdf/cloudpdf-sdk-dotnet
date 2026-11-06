using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfMeasurementRectilinearSlopeItemLabelPosition.PdfMeasurementRectilinearSlopeItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct PdfMeasurementRectilinearSlopeItemLabelPosition : IStringEnum
{
    public static readonly PdfMeasurementRectilinearSlopeItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly PdfMeasurementRectilinearSlopeItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public PdfMeasurementRectilinearSlopeItemLabelPosition(string value)
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
    public static PdfMeasurementRectilinearSlopeItemLabelPosition FromCustom(string value)
    {
        return new PdfMeasurementRectilinearSlopeItemLabelPosition(value);
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
        PdfMeasurementRectilinearSlopeItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PdfMeasurementRectilinearSlopeItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PdfMeasurementRectilinearSlopeItemLabelPosition value) =>
        value.Value;

    public static explicit operator PdfMeasurementRectilinearSlopeItemLabelPosition(string value) =>
        new(value);

    internal class PdfMeasurementRectilinearSlopeItemLabelPositionSerializer
        : JsonConverter<PdfMeasurementRectilinearSlopeItemLabelPosition>
    {
        public override PdfMeasurementRectilinearSlopeItemLabelPosition Read(
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
            return new PdfMeasurementRectilinearSlopeItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearSlopeItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfMeasurementRectilinearSlopeItemLabelPosition ReadAsPropertyName(
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
            return new PdfMeasurementRectilinearSlopeItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearSlopeItemLabelPosition value,
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
        public const string Suffix = "suffix";

        public const string Prefix = "prefix";
    }
}
