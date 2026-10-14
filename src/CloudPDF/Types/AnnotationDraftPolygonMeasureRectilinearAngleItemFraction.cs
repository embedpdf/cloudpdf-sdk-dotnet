using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolygonMeasureRectilinearAngleItemFraction.AnnotationDraftPolygonMeasureRectilinearAngleItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolygonMeasureRectilinearAngleItemFraction
    : IStringEnum
{
    public static readonly AnnotationDraftPolygonMeasureRectilinearAngleItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationDraftPolygonMeasureRectilinearAngleItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationDraftPolygonMeasureRectilinearAngleItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationDraftPolygonMeasureRectilinearAngleItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationDraftPolygonMeasureRectilinearAngleItemFraction(string value)
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
    public static AnnotationDraftPolygonMeasureRectilinearAngleItemFraction FromCustom(string value)
    {
        return new AnnotationDraftPolygonMeasureRectilinearAngleItemFraction(value);
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
        AnnotationDraftPolygonMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftPolygonMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftPolygonMeasureRectilinearAngleItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationDraftPolygonMeasureRectilinearAngleItemFraction(
        string value
    ) => new(value);

    internal class AnnotationDraftPolygonMeasureRectilinearAngleItemFractionSerializer
        : JsonConverter<AnnotationDraftPolygonMeasureRectilinearAngleItemFraction>
    {
        public override AnnotationDraftPolygonMeasureRectilinearAngleItemFraction Read(
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
            return new AnnotationDraftPolygonMeasureRectilinearAngleItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearAngleItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolygonMeasureRectilinearAngleItemFraction ReadAsPropertyName(
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
            return new AnnotationDraftPolygonMeasureRectilinearAngleItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearAngleItemFraction value,
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
