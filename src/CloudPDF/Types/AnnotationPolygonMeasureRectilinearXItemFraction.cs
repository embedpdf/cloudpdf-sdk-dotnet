using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPolygonMeasureRectilinearXItemFraction.AnnotationPolygonMeasureRectilinearXItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPolygonMeasureRectilinearXItemFraction : IStringEnum
{
    public static readonly AnnotationPolygonMeasureRectilinearXItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPolygonMeasureRectilinearXItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPolygonMeasureRectilinearXItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPolygonMeasureRectilinearXItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPolygonMeasureRectilinearXItemFraction(string value)
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
    public static AnnotationPolygonMeasureRectilinearXItemFraction FromCustom(string value)
    {
        return new AnnotationPolygonMeasureRectilinearXItemFraction(value);
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
        AnnotationPolygonMeasureRectilinearXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPolygonMeasureRectilinearXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPolygonMeasureRectilinearXItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPolygonMeasureRectilinearXItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPolygonMeasureRectilinearXItemFractionSerializer
        : JsonConverter<AnnotationPolygonMeasureRectilinearXItemFraction>
    {
        public override AnnotationPolygonMeasureRectilinearXItemFraction Read(
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
            return new AnnotationPolygonMeasureRectilinearXItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolygonMeasureRectilinearXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolygonMeasureRectilinearXItemFraction ReadAsPropertyName(
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
            return new AnnotationPolygonMeasureRectilinearXItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolygonMeasureRectilinearXItemFraction value,
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
