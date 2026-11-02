using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesRemoveName200ResponseLayoutLabelsItemStyle.DocPagesRemoveName200ResponseLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct DocPagesRemoveName200ResponseLayoutLabelsItemStyle : IStringEnum
{
    public static readonly DocPagesRemoveName200ResponseLayoutLabelsItemStyle Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesRemoveName200ResponseLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly DocPagesRemoveName200ResponseLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly DocPagesRemoveName200ResponseLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly DocPagesRemoveName200ResponseLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public DocPagesRemoveName200ResponseLayoutLabelsItemStyle(string value)
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
    public static DocPagesRemoveName200ResponseLayoutLabelsItemStyle FromCustom(string value)
    {
        return new DocPagesRemoveName200ResponseLayoutLabelsItemStyle(value);
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
        DocPagesRemoveName200ResponseLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesRemoveName200ResponseLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesRemoveName200ResponseLayoutLabelsItemStyle value
    ) => value.Value;

    public static explicit operator DocPagesRemoveName200ResponseLayoutLabelsItemStyle(
        string value
    ) => new(value);

    internal class DocPagesRemoveName200ResponseLayoutLabelsItemStyleSerializer
        : JsonConverter<DocPagesRemoveName200ResponseLayoutLabelsItemStyle>
    {
        public override DocPagesRemoveName200ResponseLayoutLabelsItemStyle Read(
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
            return new DocPagesRemoveName200ResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesRemoveName200ResponseLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesRemoveName200ResponseLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new DocPagesRemoveName200ResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesRemoveName200ResponseLayoutLabelsItemStyle value,
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

        public const string UpperRoman = "upperRoman";

        public const string LowerRoman = "lowerRoman";

        public const string UpperLetters = "upperLetters";

        public const string LowerLetters = "lowerLetters";
    }
}
