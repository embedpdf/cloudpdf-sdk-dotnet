using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendModeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Normal =
        new(Values.Normal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Multiply =
        new(Values.Multiply);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Screen =
        new(Values.Screen);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Overlay =
        new(Values.Overlay);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Darken =
        new(Values.Darken);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Lighten =
        new(Values.Lighten);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode ColorDodge =
        new(Values.ColorDodge);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode ColorBurn =
        new(Values.ColorBurn);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode HardLight =
        new(Values.HardLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode SoftLight =
        new(Values.SoftLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Difference =
        new(Values.Difference);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Exclusion =
        new(Values.Exclusion);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Hue =
        new(Values.Hue);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Saturation =
        new(Values.Saturation);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Color =
        new(Values.Color);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Luminosity =
        new(Values.Luminosity);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendModeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineBlendMode value,
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
