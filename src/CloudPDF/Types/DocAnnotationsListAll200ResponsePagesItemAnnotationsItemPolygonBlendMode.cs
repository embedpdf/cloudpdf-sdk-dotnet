using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendModeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Normal =
        new(Values.Normal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Multiply =
        new(Values.Multiply);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Screen =
        new(Values.Screen);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Overlay =
        new(Values.Overlay);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Darken =
        new(Values.Darken);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Lighten =
        new(Values.Lighten);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode ColorDodge =
        new(Values.ColorDodge);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode ColorBurn =
        new(Values.ColorBurn);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode HardLight =
        new(Values.HardLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode SoftLight =
        new(Values.SoftLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Difference =
        new(Values.Difference);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Exclusion =
        new(Values.Exclusion);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Hue =
        new(Values.Hue);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Saturation =
        new(Values.Saturation);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Color =
        new(Values.Color);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Luminosity =
        new(Values.Luminosity);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendModeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonBlendMode value,
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
