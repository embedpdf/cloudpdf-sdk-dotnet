using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesSetNameResponseLayoutLabelsItemStyle.DocPagesSetNameResponseLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetNameResponseLayoutLabelsItemStyle : IStringEnum
{
    public static readonly DocPagesSetNameResponseLayoutLabelsItemStyle Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesSetNameResponseLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly DocPagesSetNameResponseLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly DocPagesSetNameResponseLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly DocPagesSetNameResponseLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public DocPagesSetNameResponseLayoutLabelsItemStyle(string value)
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
    public static DocPagesSetNameResponseLayoutLabelsItemStyle FromCustom(string value)
    {
        return new DocPagesSetNameResponseLayoutLabelsItemStyle(value);
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
        DocPagesSetNameResponseLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetNameResponseLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesSetNameResponseLayoutLabelsItemStyle value) =>
        value.Value;

    public static explicit operator DocPagesSetNameResponseLayoutLabelsItemStyle(string value) =>
        new(value);

    internal class DocPagesSetNameResponseLayoutLabelsItemStyleSerializer
        : JsonConverter<DocPagesSetNameResponseLayoutLabelsItemStyle>
    {
        public override DocPagesSetNameResponseLayoutLabelsItemStyle Read(
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
            return new DocPagesSetNameResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetNameResponseLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetNameResponseLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new DocPagesSetNameResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetNameResponseLayoutLabelsItemStyle value,
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
