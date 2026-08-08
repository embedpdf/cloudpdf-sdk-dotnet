using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily.DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamilySerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily Courier =
        new(Values.Courier);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily CourierBold =
        new(Values.CourierBold);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily CourierBoldOblique =
        new(Values.CourierBoldOblique);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily CourierOblique =
        new(Values.CourierOblique);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily Helvetica =
        new(Values.Helvetica);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily HelveticaBold =
        new(Values.HelveticaBold);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily HelveticaBoldOblique =
        new(Values.HelveticaBoldOblique);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily HelveticaOblique =
        new(Values.HelveticaOblique);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily TimesRoman =
        new(Values.TimesRoman);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily TimesBold =
        new(Values.TimesBold);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily TimesBoldItalic =
        new(Values.TimesBoldItalic);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily TimesItalic =
        new(Values.TimesItalic);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily Symbol =
        new(Values.Symbol);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily ZapfDingbats =
        new(Values.ZapfDingbats);

    public DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily(value);
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
        DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamilySerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily value,
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
        public const string Courier = "courier";

        public const string CourierBold = "courier-bold";

        public const string CourierBoldOblique = "courier-bold-oblique";

        public const string CourierOblique = "courier-oblique";

        public const string Helvetica = "helvetica";

        public const string HelveticaBold = "helvetica-bold";

        public const string HelveticaBoldOblique = "helvetica-bold-oblique";

        public const string HelveticaOblique = "helvetica-oblique";

        public const string TimesRoman = "times-roman";

        public const string TimesBold = "times-bold";

        public const string TimesBoldItalic = "times-bold-italic";

        public const string TimesItalic = "times-italic";

        public const string Symbol = "symbol";

        public const string ZapfDingbats = "zapf-dingbats";
    }
}
