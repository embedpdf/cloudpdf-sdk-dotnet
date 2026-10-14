using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchLinkBlendMode.AnnotationPatchLinkBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchLinkBlendMode : IStringEnum
{
    public static readonly AnnotationPatchLinkBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchLinkBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchLinkBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchLinkBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchLinkBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchLinkBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchLinkBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchLinkBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchLinkBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchLinkBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchLinkBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchLinkBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchLinkBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchLinkBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchLinkBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchLinkBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchLinkBlendMode(string value)
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
    public static AnnotationPatchLinkBlendMode FromCustom(string value)
    {
        return new AnnotationPatchLinkBlendMode(value);
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

    public static bool operator ==(AnnotationPatchLinkBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchLinkBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchLinkBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchLinkBlendMode(string value) => new(value);

    internal class AnnotationPatchLinkBlendModeSerializer
        : JsonConverter<AnnotationPatchLinkBlendMode>
    {
        public override AnnotationPatchLinkBlendMode Read(
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
            return new AnnotationPatchLinkBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLinkBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLinkBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchLinkBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLinkBlendMode value,
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
