using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction.DocPagesViewports200ResponseItemMeasureRlDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction Round =
        new(Values.Round);

    public static readonly DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction Truncate =
        new(Values.Truncate);

    public DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction(string value)
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
    public static DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction(value);
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
        DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseItemMeasureRlDistanceItemFractionSerializer
        : JsonConverter<DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction>
    {
        public override DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction Read(
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
            return new DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlDistanceItemFraction value,
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
