using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPolylineMeasureRectilinearSlopeItemFraction.AnnotationPolylineMeasureRectilinearSlopeItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPolylineMeasureRectilinearSlopeItemFraction : IStringEnum
{
    public static readonly AnnotationPolylineMeasureRectilinearSlopeItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPolylineMeasureRectilinearSlopeItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPolylineMeasureRectilinearSlopeItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPolylineMeasureRectilinearSlopeItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPolylineMeasureRectilinearSlopeItemFraction(string value)
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
    public static AnnotationPolylineMeasureRectilinearSlopeItemFraction FromCustom(string value)
    {
        return new AnnotationPolylineMeasureRectilinearSlopeItemFraction(value);
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
        AnnotationPolylineMeasureRectilinearSlopeItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPolylineMeasureRectilinearSlopeItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPolylineMeasureRectilinearSlopeItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPolylineMeasureRectilinearSlopeItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPolylineMeasureRectilinearSlopeItemFractionSerializer
        : JsonConverter<AnnotationPolylineMeasureRectilinearSlopeItemFraction>
    {
        public override AnnotationPolylineMeasureRectilinearSlopeItemFraction Read(
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
            return new AnnotationPolylineMeasureRectilinearSlopeItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolylineMeasureRectilinearSlopeItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolylineMeasureRectilinearSlopeItemFraction ReadAsPropertyName(
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
            return new AnnotationPolylineMeasureRectilinearSlopeItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolylineMeasureRectilinearSlopeItemFraction value,
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
