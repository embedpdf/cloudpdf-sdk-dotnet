using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolygonMeasureRectilinearYItemFraction.AnnotationPatchPolygonMeasureRectilinearYItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolygonMeasureRectilinearYItemFraction : IStringEnum
{
    public static readonly AnnotationPatchPolygonMeasureRectilinearYItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearYItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearYItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearYItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPatchPolygonMeasureRectilinearYItemFraction(string value)
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
    public static AnnotationPatchPolygonMeasureRectilinearYItemFraction FromCustom(string value)
    {
        return new AnnotationPatchPolygonMeasureRectilinearYItemFraction(value);
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
        AnnotationPatchPolygonMeasureRectilinearYItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchPolygonMeasureRectilinearYItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchPolygonMeasureRectilinearYItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPatchPolygonMeasureRectilinearYItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPatchPolygonMeasureRectilinearYItemFractionSerializer
        : JsonConverter<AnnotationPatchPolygonMeasureRectilinearYItemFraction>
    {
        public override AnnotationPatchPolygonMeasureRectilinearYItemFraction Read(
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
            return new AnnotationPatchPolygonMeasureRectilinearYItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearYItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolygonMeasureRectilinearYItemFraction ReadAsPropertyName(
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
            return new AnnotationPatchPolygonMeasureRectilinearYItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearYItemFraction value,
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
