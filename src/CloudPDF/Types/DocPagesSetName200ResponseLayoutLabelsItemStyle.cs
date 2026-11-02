using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesSetName200ResponseLayoutLabelsItemStyle.DocPagesSetName200ResponseLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetName200ResponseLayoutLabelsItemStyle : IStringEnum
{
    public static readonly DocPagesSetName200ResponseLayoutLabelsItemStyle Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesSetName200ResponseLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly DocPagesSetName200ResponseLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly DocPagesSetName200ResponseLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly DocPagesSetName200ResponseLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public DocPagesSetName200ResponseLayoutLabelsItemStyle(string value)
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
    public static DocPagesSetName200ResponseLayoutLabelsItemStyle FromCustom(string value)
    {
        return new DocPagesSetName200ResponseLayoutLabelsItemStyle(value);
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
        DocPagesSetName200ResponseLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetName200ResponseLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesSetName200ResponseLayoutLabelsItemStyle value) =>
        value.Value;

    public static explicit operator DocPagesSetName200ResponseLayoutLabelsItemStyle(string value) =>
        new(value);

    internal class DocPagesSetName200ResponseLayoutLabelsItemStyleSerializer
        : JsonConverter<DocPagesSetName200ResponseLayoutLabelsItemStyle>
    {
        public override DocPagesSetName200ResponseLayoutLabelsItemStyle Read(
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
            return new DocPagesSetName200ResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetName200ResponseLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetName200ResponseLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new DocPagesSetName200ResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetName200ResponseLayoutLabelsItemStyle value,
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
