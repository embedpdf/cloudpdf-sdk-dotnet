using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchCircleBlendMode.AnnotationPatchCircleBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchCircleBlendMode : IStringEnum
{
    public static readonly AnnotationPatchCircleBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchCircleBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchCircleBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchCircleBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchCircleBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchCircleBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchCircleBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchCircleBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchCircleBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchCircleBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchCircleBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchCircleBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchCircleBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchCircleBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchCircleBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchCircleBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchCircleBlendMode(string value)
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
    public static AnnotationPatchCircleBlendMode FromCustom(string value)
    {
        return new AnnotationPatchCircleBlendMode(value);
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

    public static bool operator ==(AnnotationPatchCircleBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchCircleBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchCircleBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchCircleBlendMode(string value) => new(value);

    internal class AnnotationPatchCircleBlendModeSerializer
        : JsonConverter<AnnotationPatchCircleBlendMode>
    {
        public override AnnotationPatchCircleBlendMode Read(
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
            return new AnnotationPatchCircleBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchCircleBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchCircleBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchCircleBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchCircleBlendMode value,
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
