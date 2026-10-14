using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPolygonMeasureRectilinearAreaItemFraction.AnnotationPolygonMeasureRectilinearAreaItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPolygonMeasureRectilinearAreaItemFraction : IStringEnum
{
    public static readonly AnnotationPolygonMeasureRectilinearAreaItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPolygonMeasureRectilinearAreaItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPolygonMeasureRectilinearAreaItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPolygonMeasureRectilinearAreaItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPolygonMeasureRectilinearAreaItemFraction(string value)
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
    public static AnnotationPolygonMeasureRectilinearAreaItemFraction FromCustom(string value)
    {
        return new AnnotationPolygonMeasureRectilinearAreaItemFraction(value);
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
        AnnotationPolygonMeasureRectilinearAreaItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPolygonMeasureRectilinearAreaItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPolygonMeasureRectilinearAreaItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPolygonMeasureRectilinearAreaItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPolygonMeasureRectilinearAreaItemFractionSerializer
        : JsonConverter<AnnotationPolygonMeasureRectilinearAreaItemFraction>
    {
        public override AnnotationPolygonMeasureRectilinearAreaItemFraction Read(
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
            return new AnnotationPolygonMeasureRectilinearAreaItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolygonMeasureRectilinearAreaItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolygonMeasureRectilinearAreaItemFraction ReadAsPropertyName(
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
            return new AnnotationPolygonMeasureRectilinearAreaItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolygonMeasureRectilinearAreaItemFraction value,
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
