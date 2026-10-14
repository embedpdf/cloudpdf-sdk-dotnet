using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchStrikeoutBlendMode.AnnotationPatchStrikeoutBlendModeSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchStrikeoutBlendMode : IStringEnum
{
    public static readonly AnnotationPatchStrikeoutBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchStrikeoutBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchStrikeoutBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchStrikeoutBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchStrikeoutBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchStrikeoutBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchStrikeoutBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchStrikeoutBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchStrikeoutBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchStrikeoutBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchStrikeoutBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchStrikeoutBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchStrikeoutBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchStrikeoutBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchStrikeoutBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchStrikeoutBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchStrikeoutBlendMode(string value)
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
    public static AnnotationPatchStrikeoutBlendMode FromCustom(string value)
    {
        return new AnnotationPatchStrikeoutBlendMode(value);
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

    public static bool operator ==(AnnotationPatchStrikeoutBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchStrikeoutBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchStrikeoutBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchStrikeoutBlendMode(string value) => new(value);

    internal class AnnotationPatchStrikeoutBlendModeSerializer
        : JsonConverter<AnnotationPatchStrikeoutBlendMode>
    {
        public override AnnotationPatchStrikeoutBlendMode Read(
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
            return new AnnotationPatchStrikeoutBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchStrikeoutBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchStrikeoutBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchStrikeoutBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchStrikeoutBlendMode value,
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
