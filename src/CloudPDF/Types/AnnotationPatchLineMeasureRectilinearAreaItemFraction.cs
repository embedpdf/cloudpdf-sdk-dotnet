using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchLineMeasureRectilinearAreaItemFraction.AnnotationPatchLineMeasureRectilinearAreaItemFractionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchLineMeasureRectilinearAreaItemFraction : IStringEnum
{
    public static readonly AnnotationPatchLineMeasureRectilinearAreaItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly AnnotationPatchLineMeasureRectilinearAreaItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly AnnotationPatchLineMeasureRectilinearAreaItemFraction Round = new(
        Values.Round
    );

    public static readonly AnnotationPatchLineMeasureRectilinearAreaItemFraction Truncate = new(
        Values.Truncate
    );

    public AnnotationPatchLineMeasureRectilinearAreaItemFraction(string value)
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
    public static AnnotationPatchLineMeasureRectilinearAreaItemFraction FromCustom(string value)
    {
        return new AnnotationPatchLineMeasureRectilinearAreaItemFraction(value);
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
        AnnotationPatchLineMeasureRectilinearAreaItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchLineMeasureRectilinearAreaItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchLineMeasureRectilinearAreaItemFraction value
    ) => value.Value;

    public static explicit operator AnnotationPatchLineMeasureRectilinearAreaItemFraction(
        string value
    ) => new(value);

    internal class AnnotationPatchLineMeasureRectilinearAreaItemFractionSerializer
        : JsonConverter<AnnotationPatchLineMeasureRectilinearAreaItemFraction>
    {
        public override AnnotationPatchLineMeasureRectilinearAreaItemFraction Read(
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
            return new AnnotationPatchLineMeasureRectilinearAreaItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureRectilinearAreaItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineMeasureRectilinearAreaItemFraction ReadAsPropertyName(
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
            return new AnnotationPatchLineMeasureRectilinearAreaItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureRectilinearAreaItemFraction value,
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
