using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftLineMeasureRectilinearDistanceItemFraction.AnnotationDraftLineMeasureRectilinearDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftLineMeasureRectilinearDistanceItemFraction
    : IStringEnum
{
    public static readonly AnnotationDraftLineMeasureRectilinearDistanceItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationDraftLineMeasureRectilinearDistanceItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationDraftLineMeasureRectilinearDistanceItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationDraftLineMeasureRectilinearDistanceItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationDraftLineMeasureRectilinearDistanceItemFraction(string value)
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
    public static AnnotationDraftLineMeasureRectilinearDistanceItemFraction FromCustom(string value)
    {
        return new AnnotationDraftLineMeasureRectilinearDistanceItemFraction(value);
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
        AnnotationDraftLineMeasureRectilinearDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftLineMeasureRectilinearDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftLineMeasureRectilinearDistanceItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationDraftLineMeasureRectilinearDistanceItemFraction(
        string value
    ) => new(value);

    internal class AnnotationDraftLineMeasureRectilinearDistanceItemFractionSerializer
        : JsonConverter<AnnotationDraftLineMeasureRectilinearDistanceItemFraction>
    {
        public override AnnotationDraftLineMeasureRectilinearDistanceItemFraction Read(
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
            return new AnnotationDraftLineMeasureRectilinearDistanceItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLineMeasureRectilinearDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLineMeasureRectilinearDistanceItemFraction ReadAsPropertyName(
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
            return new AnnotationDraftLineMeasureRectilinearDistanceItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLineMeasureRectilinearDistanceItemFraction value,
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
