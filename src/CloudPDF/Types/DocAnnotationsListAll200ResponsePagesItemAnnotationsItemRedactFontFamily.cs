using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamilySerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily Courier =
        new(Values.Courier);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily CourierBold =
        new(Values.CourierBold);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily CourierBoldOblique =
        new(Values.CourierBoldOblique);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily CourierOblique =
        new(Values.CourierOblique);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily Helvetica =
        new(Values.Helvetica);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily HelveticaBold =
        new(Values.HelveticaBold);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily HelveticaBoldOblique =
        new(Values.HelveticaBoldOblique);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily HelveticaOblique =
        new(Values.HelveticaOblique);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily TimesRoman =
        new(Values.TimesRoman);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily TimesBold =
        new(Values.TimesBold);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily TimesBoldItalic =
        new(Values.TimesBoldItalic);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily TimesItalic =
        new(Values.TimesItalic);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily Symbol =
        new(Values.Symbol);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily ZapfDingbats =
        new(Values.ZapfDingbats);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamilySerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactFontFamily value,
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
