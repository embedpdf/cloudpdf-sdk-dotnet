using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction.AnnotationDraftPolygonMeasureRectilinearDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction
    : IStringEnum
{
    public static readonly AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction Decimal =
        new(Values.Decimal);

    public static readonly AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction Fraction =
        new(Values.Fraction);

    public static readonly AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction Truncate =
        new(Values.Truncate);

    public AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction(string value)
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
    public static AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction FromCustom(
        string value
    )
    {
        return new AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction(value);
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
        AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction(
        string value
    ) => new(value);

    internal class AnnotationDraftPolygonMeasureRectilinearDistanceItemFractionSerializer
        : JsonConverter<AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction>
    {
        public override AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction Read(
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
            return new AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction ReadAsPropertyName(
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
            return new AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearDistanceItemFraction value,
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
