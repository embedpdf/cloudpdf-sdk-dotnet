using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchLineBlendMode.AnnotationPatchLineBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchLineBlendMode : IStringEnum
{
    public static readonly AnnotationPatchLineBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchLineBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchLineBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchLineBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchLineBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchLineBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchLineBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchLineBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchLineBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchLineBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchLineBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchLineBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchLineBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchLineBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchLineBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchLineBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchLineBlendMode(string value)
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
    public static AnnotationPatchLineBlendMode FromCustom(string value)
    {
        return new AnnotationPatchLineBlendMode(value);
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

    public static bool operator ==(AnnotationPatchLineBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchLineBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchLineBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchLineBlendMode(string value) => new(value);

    internal class AnnotationPatchLineBlendModeSerializer
        : JsonConverter<AnnotationPatchLineBlendMode>
    {
        public override AnnotationPatchLineBlendMode Read(
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
            return new AnnotationPatchLineBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchLineBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineBlendMode value,
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
