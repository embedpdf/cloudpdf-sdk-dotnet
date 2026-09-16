using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScriptSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript Normal =
        new(Values.Normal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript Sub =
        new(Values.Sub);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript Super =
        new(Values.Super);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScriptSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextBodyScript value,
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
        public const string Normal = "normal";

        public const string Sub = "sub";

        public const string Super = "super";
    }
}
