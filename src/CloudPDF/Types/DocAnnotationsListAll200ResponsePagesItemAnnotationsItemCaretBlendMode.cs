using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendModeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Normal =
        new(Values.Normal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Multiply =
        new(Values.Multiply);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Screen =
        new(Values.Screen);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Overlay =
        new(Values.Overlay);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Darken =
        new(Values.Darken);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Lighten =
        new(Values.Lighten);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode ColorDodge =
        new(Values.ColorDodge);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode ColorBurn =
        new(Values.ColorBurn);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode HardLight =
        new(Values.HardLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode SoftLight =
        new(Values.SoftLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Difference =
        new(Values.Difference);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Exclusion =
        new(Values.Exclusion);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Hue =
        new(Values.Hue);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Saturation =
        new(Values.Saturation);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Color =
        new(Values.Color);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Luminosity =
        new(Values.Luminosity);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendModeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode value,
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

        public const string Multiply = "multiply";

        public const string Screen = "screen";

        public const string Overlay = "overlay";

        public const string Darken = "darken";

        public const string Lighten = "lighten";

        public const string ColorDodge = "color-dodge";

        public const string ColorBurn = "color-burn";

        public const string HardLight = "hard-light";

        public const string SoftLight = "soft-light";

        public const string Difference = "difference";

        public const string Exclusion = "exclusion";

        public const string Hue = "hue";

        public const string Saturation = "saturation";

        public const string Color = "color";

        public const string Luminosity = "luminosity";
    }
}
