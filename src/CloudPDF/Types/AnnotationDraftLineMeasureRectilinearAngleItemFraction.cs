using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftLineMeasureRectilinearAngleItemFraction.AnnotationDraftLineMeasureRectilinearAngleItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftLineMeasureRectilinearAngleItemFraction : IStringEnum
{
    public static readonly AnnotationDraftLineMeasureRectilinearAngleItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationDraftLineMeasureRectilinearAngleItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationDraftLineMeasureRectilinearAngleItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationDraftLineMeasureRectilinearAngleItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationDraftLineMeasureRectilinearAngleItemFraction(string value)
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
    public static AnnotationDraftLineMeasureRectilinearAngleItemFraction FromCustom(string value)
    {
        return new AnnotationDraftLineMeasureRectilinearAngleItemFraction(value);
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
        AnnotationDraftLineMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftLineMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftLineMeasureRectilinearAngleItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationDraftLineMeasureRectilinearAngleItemFraction(
        string value
    ) => new(value);

    internal class AnnotationDraftLineMeasureRectilinearAngleItemFractionSerializer
        : JsonConverter<AnnotationDraftLineMeasureRectilinearAngleItemFraction>
    {
        public override AnnotationDraftLineMeasureRectilinearAngleItemFraction Read(
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
            return new AnnotationDraftLineMeasureRectilinearAngleItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLineMeasureRectilinearAngleItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLineMeasureRectilinearAngleItemFraction ReadAsPropertyName(
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
            return new AnnotationDraftLineMeasureRectilinearAngleItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLineMeasureRectilinearAngleItemFraction value,
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
