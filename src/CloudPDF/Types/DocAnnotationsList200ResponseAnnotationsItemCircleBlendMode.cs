using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode.DocAnnotationsList200ResponseAnnotationsItemCircleBlendModeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Normal = new(
        Values.Normal
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Multiply =
        new(Values.Multiply);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Screen = new(
        Values.Screen
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Overlay =
        new(Values.Overlay);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Darken = new(
        Values.Darken
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Lighten =
        new(Values.Lighten);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode ColorDodge =
        new(Values.ColorDodge);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode ColorBurn =
        new(Values.ColorBurn);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode HardLight =
        new(Values.HardLight);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode SoftLight =
        new(Values.SoftLight);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Difference =
        new(Values.Difference);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Exclusion =
        new(Values.Exclusion);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Hue = new(
        Values.Hue
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Saturation =
        new(Values.Saturation);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Color = new(
        Values.Color
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Luminosity =
        new(Values.Luminosity);

    public DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode(value);
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
        DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemCircleBlendModeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleBlendMode value,
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
