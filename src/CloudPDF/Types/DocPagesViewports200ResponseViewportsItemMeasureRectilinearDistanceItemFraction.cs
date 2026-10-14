using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction.DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction Round =
        new(Values.Round);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction Truncate =
        new(Values.Truncate);

    public DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction(
        string value
    )
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
    public static DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction(
            value
        );
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
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFractionSerializer
        : JsonConverter<DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction>
    {
        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction Read(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItemFraction value,
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
