using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchLineMeasureRectilinearSlopeItemFraction.AnnotationPatchLineMeasureRectilinearSlopeItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchLineMeasureRectilinearSlopeItemFraction : IStringEnum
{
    public static readonly AnnotationPatchLineMeasureRectilinearSlopeItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPatchLineMeasureRectilinearSlopeItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPatchLineMeasureRectilinearSlopeItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPatchLineMeasureRectilinearSlopeItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPatchLineMeasureRectilinearSlopeItemFraction(string value)
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
    public static AnnotationPatchLineMeasureRectilinearSlopeItemFraction FromCustom(string value)
    {
        return new AnnotationPatchLineMeasureRectilinearSlopeItemFraction(value);
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
        AnnotationPatchLineMeasureRectilinearSlopeItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchLineMeasureRectilinearSlopeItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchLineMeasureRectilinearSlopeItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPatchLineMeasureRectilinearSlopeItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPatchLineMeasureRectilinearSlopeItemFractionSerializer
        : JsonConverter<AnnotationPatchLineMeasureRectilinearSlopeItemFraction>
    {
        public override AnnotationPatchLineMeasureRectilinearSlopeItemFraction Read(
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
            return new AnnotationPatchLineMeasureRectilinearSlopeItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureRectilinearSlopeItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineMeasureRectilinearSlopeItemFraction ReadAsPropertyName(
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
            return new AnnotationPatchLineMeasureRectilinearSlopeItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureRectilinearSlopeItemFraction value,
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
