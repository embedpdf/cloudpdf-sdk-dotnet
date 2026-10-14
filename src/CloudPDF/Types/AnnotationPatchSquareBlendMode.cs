using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchSquareBlendMode.AnnotationPatchSquareBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchSquareBlendMode : IStringEnum
{
    public static readonly AnnotationPatchSquareBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchSquareBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchSquareBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchSquareBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchSquareBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchSquareBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchSquareBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchSquareBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchSquareBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchSquareBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchSquareBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchSquareBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchSquareBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchSquareBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchSquareBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchSquareBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchSquareBlendMode(string value)
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
    public static AnnotationPatchSquareBlendMode FromCustom(string value)
    {
        return new AnnotationPatchSquareBlendMode(value);
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

    public static bool operator ==(AnnotationPatchSquareBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchSquareBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchSquareBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchSquareBlendMode(string value) => new(value);

    internal class AnnotationPatchSquareBlendModeSerializer
        : JsonConverter<AnnotationPatchSquareBlendMode>
    {
        public override AnnotationPatchSquareBlendMode Read(
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
            return new AnnotationPatchSquareBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchSquareBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchSquareBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchSquareBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchSquareBlendMode value,
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
