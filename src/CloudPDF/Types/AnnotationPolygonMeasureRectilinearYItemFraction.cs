using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPolygonMeasureRectilinearYItemFraction.AnnotationPolygonMeasureRectilinearYItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPolygonMeasureRectilinearYItemFraction : IStringEnum
{
    public static readonly AnnotationPolygonMeasureRectilinearYItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPolygonMeasureRectilinearYItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPolygonMeasureRectilinearYItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPolygonMeasureRectilinearYItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPolygonMeasureRectilinearYItemFraction(string value)
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
    public static AnnotationPolygonMeasureRectilinearYItemFraction FromCustom(string value)
    {
        return new AnnotationPolygonMeasureRectilinearYItemFraction(value);
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
        AnnotationPolygonMeasureRectilinearYItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPolygonMeasureRectilinearYItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPolygonMeasureRectilinearYItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPolygonMeasureRectilinearYItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPolygonMeasureRectilinearYItemFractionSerializer
        : JsonConverter<AnnotationPolygonMeasureRectilinearYItemFraction>
    {
        public override AnnotationPolygonMeasureRectilinearYItemFraction Read(
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
            return new AnnotationPolygonMeasureRectilinearYItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolygonMeasureRectilinearYItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolygonMeasureRectilinearYItemFraction ReadAsPropertyName(
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
            return new AnnotationPolygonMeasureRectilinearYItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolygonMeasureRectilinearYItemFraction value,
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
