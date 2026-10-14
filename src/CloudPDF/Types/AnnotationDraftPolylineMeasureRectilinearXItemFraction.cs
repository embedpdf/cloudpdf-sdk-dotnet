using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolylineMeasureRectilinearXItemFraction.AnnotationDraftPolylineMeasureRectilinearXItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolylineMeasureRectilinearXItemFraction : IStringEnum
{
    public static readonly AnnotationDraftPolylineMeasureRectilinearXItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationDraftPolylineMeasureRectilinearXItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationDraftPolylineMeasureRectilinearXItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationDraftPolylineMeasureRectilinearXItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationDraftPolylineMeasureRectilinearXItemFraction(string value)
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
    public static AnnotationDraftPolylineMeasureRectilinearXItemFraction FromCustom(string value)
    {
        return new AnnotationDraftPolylineMeasureRectilinearXItemFraction(value);
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
        AnnotationDraftPolylineMeasureRectilinearXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftPolylineMeasureRectilinearXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftPolylineMeasureRectilinearXItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationDraftPolylineMeasureRectilinearXItemFraction(
        string value
    ) => new(value);

    internal class AnnotationDraftPolylineMeasureRectilinearXItemFractionSerializer
        : JsonConverter<AnnotationDraftPolylineMeasureRectilinearXItemFraction>
    {
        public override AnnotationDraftPolylineMeasureRectilinearXItemFraction Read(
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
            return new AnnotationDraftPolylineMeasureRectilinearXItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasureRectilinearXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolylineMeasureRectilinearXItemFraction ReadAsPropertyName(
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
            return new AnnotationDraftPolylineMeasureRectilinearXItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasureRectilinearXItemFraction value,
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
