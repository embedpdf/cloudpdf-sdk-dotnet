using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolygonMeasureRectilinearYItemFraction.AnnotationDraftPolygonMeasureRectilinearYItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolygonMeasureRectilinearYItemFraction : IStringEnum
{
    public static readonly AnnotationDraftPolygonMeasureRectilinearYItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationDraftPolygonMeasureRectilinearYItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationDraftPolygonMeasureRectilinearYItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationDraftPolygonMeasureRectilinearYItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationDraftPolygonMeasureRectilinearYItemFraction(string value)
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
    public static AnnotationDraftPolygonMeasureRectilinearYItemFraction FromCustom(string value)
    {
        return new AnnotationDraftPolygonMeasureRectilinearYItemFraction(value);
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
        AnnotationDraftPolygonMeasureRectilinearYItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftPolygonMeasureRectilinearYItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftPolygonMeasureRectilinearYItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationDraftPolygonMeasureRectilinearYItemFraction(
        string value
    ) => new(value);

    internal class AnnotationDraftPolygonMeasureRectilinearYItemFractionSerializer
        : JsonConverter<AnnotationDraftPolygonMeasureRectilinearYItemFraction>
    {
        public override AnnotationDraftPolygonMeasureRectilinearYItemFraction Read(
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
            return new AnnotationDraftPolygonMeasureRectilinearYItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearYItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolygonMeasureRectilinearYItemFraction ReadAsPropertyName(
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
            return new AnnotationDraftPolygonMeasureRectilinearYItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearYItemFraction value,
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
