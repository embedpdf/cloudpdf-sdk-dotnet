using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript.AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScriptSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript
    : IStringEnum
{
    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript Normal =
        new(Values.Normal);

    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript Sub =
        new(Values.Sub);

    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript Super =
        new(Values.Super);

    public AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript(string value)
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
    public static AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript FromCustom(
        string value
    )
    {
        return new AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript(value);
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
        AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript value
    ) => value.Value;

    public static explicit operator AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript(
        string value
    ) => new(value);

    internal class AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScriptSerializer
        : JsonConverter<AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript>
    {
        public override AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript Read(
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
            return new AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextParagraphsItemRunsItemStyleScript value,
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
