using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolygonMeasureRectilinearXItemFraction.AnnotationPatchPolygonMeasureRectilinearXItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolygonMeasureRectilinearXItemFraction : IStringEnum
{
    public static readonly AnnotationPatchPolygonMeasureRectilinearXItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearXItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearXItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearXItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPatchPolygonMeasureRectilinearXItemFraction(string value)
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
    public static AnnotationPatchPolygonMeasureRectilinearXItemFraction FromCustom(string value)
    {
        return new AnnotationPatchPolygonMeasureRectilinearXItemFraction(value);
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
        AnnotationPatchPolygonMeasureRectilinearXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchPolygonMeasureRectilinearXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchPolygonMeasureRectilinearXItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPatchPolygonMeasureRectilinearXItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPatchPolygonMeasureRectilinearXItemFractionSerializer
        : JsonConverter<AnnotationPatchPolygonMeasureRectilinearXItemFraction>
    {
        public override AnnotationPatchPolygonMeasureRectilinearXItemFraction Read(
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
            return new AnnotationPatchPolygonMeasureRectilinearXItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolygonMeasureRectilinearXItemFraction ReadAsPropertyName(
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
            return new AnnotationPatchPolygonMeasureRectilinearXItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearXItemFraction value,
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
