using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendModeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Normal =
        new(Values.Normal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Multiply =
        new(Values.Multiply);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Screen =
        new(Values.Screen);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Overlay =
        new(Values.Overlay);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Darken =
        new(Values.Darken);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Lighten =
        new(Values.Lighten);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode ColorDodge =
        new(Values.ColorDodge);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode ColorBurn =
        new(Values.ColorBurn);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode HardLight =
        new(Values.HardLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode SoftLight =
        new(Values.SoftLight);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Difference =
        new(Values.Difference);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Exclusion =
        new(Values.Exclusion);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Hue =
        new(Values.Hue);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Saturation =
        new(Values.Saturation);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Color =
        new(Values.Color);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Luminosity =
        new(Values.Luminosity);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendModeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactBlendMode value,
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
