using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolylineMeasureRectilinearYItemFraction.AnnotationPatchPolylineMeasureRectilinearYItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolylineMeasureRectilinearYItemFraction : IStringEnum
{
    public static readonly AnnotationPatchPolylineMeasureRectilinearYItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPatchPolylineMeasureRectilinearYItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPatchPolylineMeasureRectilinearYItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPatchPolylineMeasureRectilinearYItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPatchPolylineMeasureRectilinearYItemFraction(string value)
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
    public static AnnotationPatchPolylineMeasureRectilinearYItemFraction FromCustom(string value)
    {
        return new AnnotationPatchPolylineMeasureRectilinearYItemFraction(value);
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
        AnnotationPatchPolylineMeasureRectilinearYItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchPolylineMeasureRectilinearYItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchPolylineMeasureRectilinearYItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPatchPolylineMeasureRectilinearYItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPatchPolylineMeasureRectilinearYItemFractionSerializer
        : JsonConverter<AnnotationPatchPolylineMeasureRectilinearYItemFraction>
    {
        public override AnnotationPatchPolylineMeasureRectilinearYItemFraction Read(
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
            return new AnnotationPatchPolylineMeasureRectilinearYItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineMeasureRectilinearYItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolylineMeasureRectilinearYItemFraction ReadAsPropertyName(
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
            return new AnnotationPatchPolylineMeasureRectilinearYItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineMeasureRectilinearYItemFraction value,
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
