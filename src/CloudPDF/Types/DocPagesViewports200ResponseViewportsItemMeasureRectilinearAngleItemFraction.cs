using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction.DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction Round =
        new(Values.Round);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction Truncate =
        new(Values.Truncate);

    public DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction(
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
    public static DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction(
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
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFractionSerializer
        : JsonConverter<DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction>
    {
        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction Read(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItemFraction value,
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
