using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchInkBlendMode.AnnotationPatchInkBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchInkBlendMode : IStringEnum
{
    public static readonly AnnotationPatchInkBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchInkBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchInkBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchInkBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchInkBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchInkBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchInkBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchInkBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchInkBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchInkBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchInkBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchInkBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchInkBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchInkBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchInkBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchInkBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchInkBlendMode(string value)
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
    public static AnnotationPatchInkBlendMode FromCustom(string value)
    {
        return new AnnotationPatchInkBlendMode(value);
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

    public static bool operator ==(AnnotationPatchInkBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchInkBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchInkBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchInkBlendMode(string value) => new(value);

    internal class AnnotationPatchInkBlendModeSerializer
        : JsonConverter<AnnotationPatchInkBlendMode>
    {
        public override AnnotationPatchInkBlendMode Read(
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
            return new AnnotationPatchInkBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchInkBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchInkBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchInkBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchInkBlendMode value,
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
