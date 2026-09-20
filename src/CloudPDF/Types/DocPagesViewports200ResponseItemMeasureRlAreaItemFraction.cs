using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseItemMeasureRlAreaItemFraction.DocPagesViewports200ResponseItemMeasureRlAreaItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseItemMeasureRlAreaItemFraction
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseItemMeasureRlAreaItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesViewports200ResponseItemMeasureRlAreaItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly DocPagesViewports200ResponseItemMeasureRlAreaItemFraction Round = new(
        Values.Round
    );

    public static readonly DocPagesViewports200ResponseItemMeasureRlAreaItemFraction Truncate = new(
        Values.Truncate
    );

    public DocPagesViewports200ResponseItemMeasureRlAreaItemFraction(string value)
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
    public static DocPagesViewports200ResponseItemMeasureRlAreaItemFraction FromCustom(string value)
    {
        return new DocPagesViewports200ResponseItemMeasureRlAreaItemFraction(value);
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
        DocPagesViewports200ResponseItemMeasureRlAreaItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseItemMeasureRlAreaItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseItemMeasureRlAreaItemFraction value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseItemMeasureRlAreaItemFraction(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseItemMeasureRlAreaItemFractionSerializer
        : JsonConverter<DocPagesViewports200ResponseItemMeasureRlAreaItemFraction>
    {
        public override DocPagesViewports200ResponseItemMeasureRlAreaItemFraction Read(
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
            return new DocPagesViewports200ResponseItemMeasureRlAreaItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlAreaItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseItemMeasureRlAreaItemFraction ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseItemMeasureRlAreaItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlAreaItemFraction value,
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
