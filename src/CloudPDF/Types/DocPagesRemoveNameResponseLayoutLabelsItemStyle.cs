using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesRemoveNameResponseLayoutLabelsItemStyle.DocPagesRemoveNameResponseLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct DocPagesRemoveNameResponseLayoutLabelsItemStyle : IStringEnum
{
    public static readonly DocPagesRemoveNameResponseLayoutLabelsItemStyle Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesRemoveNameResponseLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly DocPagesRemoveNameResponseLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly DocPagesRemoveNameResponseLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly DocPagesRemoveNameResponseLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public DocPagesRemoveNameResponseLayoutLabelsItemStyle(string value)
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
    public static DocPagesRemoveNameResponseLayoutLabelsItemStyle FromCustom(string value)
    {
        return new DocPagesRemoveNameResponseLayoutLabelsItemStyle(value);
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
        DocPagesRemoveNameResponseLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesRemoveNameResponseLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesRemoveNameResponseLayoutLabelsItemStyle value) =>
        value.Value;

    public static explicit operator DocPagesRemoveNameResponseLayoutLabelsItemStyle(string value) =>
        new(value);

    internal class DocPagesRemoveNameResponseLayoutLabelsItemStyleSerializer
        : JsonConverter<DocPagesRemoveNameResponseLayoutLabelsItemStyle>
    {
        public override DocPagesRemoveNameResponseLayoutLabelsItemStyle Read(
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
            return new DocPagesRemoveNameResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesRemoveNameResponseLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesRemoveNameResponseLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new DocPagesRemoveNameResponseLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesRemoveNameResponseLayoutLabelsItemStyle value,
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
