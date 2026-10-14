using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolygonMeasureRectilinearAngleItemFraction.AnnotationPatchPolygonMeasureRectilinearAngleItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolygonMeasureRectilinearAngleItemFraction
    : IStringEnum
{
    public static readonly AnnotationPatchPolygonMeasureRectilinearAngleItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearAngleItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearAngleItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPatchPolygonMeasureRectilinearAngleItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPatchPolygonMeasureRectilinearAngleItemFraction(string value)
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
    public static AnnotationPatchPolygonMeasureRectilinearAngleItemFraction FromCustom(string value)
    {
        return new AnnotationPatchPolygonMeasureRectilinearAngleItemFraction(value);
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
        AnnotationPatchPolygonMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchPolygonMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchPolygonMeasureRectilinearAngleItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPatchPolygonMeasureRectilinearAngleItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPatchPolygonMeasureRectilinearAngleItemFractionSerializer
        : JsonConverter<AnnotationPatchPolygonMeasureRectilinearAngleItemFraction>
    {
        public override AnnotationPatchPolygonMeasureRectilinearAngleItemFraction Read(
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
            return new AnnotationPatchPolygonMeasureRectilinearAngleItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearAngleItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolygonMeasureRectilinearAngleItemFraction ReadAsPropertyName(
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
            return new AnnotationPatchPolygonMeasureRectilinearAngleItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearAngleItemFraction value,
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
