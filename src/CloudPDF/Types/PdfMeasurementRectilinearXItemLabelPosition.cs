using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfMeasurementRectilinearXItemLabelPosition.PdfMeasurementRectilinearXItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct PdfMeasurementRectilinearXItemLabelPosition : IStringEnum
{
    public static readonly PdfMeasurementRectilinearXItemLabelPosition Suffix = new(Values.Suffix);

    public static readonly PdfMeasurementRectilinearXItemLabelPosition Prefix = new(Values.Prefix);

    public PdfMeasurementRectilinearXItemLabelPosition(string value)
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
    public static PdfMeasurementRectilinearXItemLabelPosition FromCustom(string value)
    {
        return new PdfMeasurementRectilinearXItemLabelPosition(value);
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
        PdfMeasurementRectilinearXItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PdfMeasurementRectilinearXItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PdfMeasurementRectilinearXItemLabelPosition value) =>
        value.Value;

    public static explicit operator PdfMeasurementRectilinearXItemLabelPosition(string value) =>
        new(value);

    internal class PdfMeasurementRectilinearXItemLabelPositionSerializer
        : JsonConverter<PdfMeasurementRectilinearXItemLabelPosition>
    {
        public override PdfMeasurementRectilinearXItemLabelPosition Read(
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
            return new PdfMeasurementRectilinearXItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearXItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfMeasurementRectilinearXItemLabelPosition ReadAsPropertyName(
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
            return new PdfMeasurementRectilinearXItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfMeasurementRectilinearXItemLabelPosition value,
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
