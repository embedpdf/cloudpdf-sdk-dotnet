using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendModeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Normal =
        new(Values.Normal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Multiply =
        new(Values.Multiply);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Screen =
        new(Values.Screen);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Overlay =
        new(Values.Overlay);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Darken =
        new(Values.Darken);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Lighten =
        new(Values.Lighten);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode ColorDodge =
        new(Values.ColorDodge);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode ColorBurn =
        new(Values.ColorBurn);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode HardLight =
        new(Values.HardLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode SoftLight =
        new(Values.SoftLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Difference =
        new(Values.Difference);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Exclusion =
        new(Values.Exclusion);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Hue =
        new(Values.Hue);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Saturation =
        new(Values.Saturation);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Color =
        new(Values.Color);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Luminosity =
        new(Values.Luminosity);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendModeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentBlendMode value,
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
