using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchCaretBlendMode.AnnotationPatchCaretBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchCaretBlendMode : IStringEnum
{
    public static readonly AnnotationPatchCaretBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchCaretBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchCaretBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchCaretBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchCaretBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchCaretBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchCaretBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchCaretBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchCaretBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchCaretBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchCaretBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchCaretBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchCaretBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchCaretBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchCaretBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchCaretBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchCaretBlendMode(string value)
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
    public static AnnotationPatchCaretBlendMode FromCustom(string value)
    {
        return new AnnotationPatchCaretBlendMode(value);
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

    public static bool operator ==(AnnotationPatchCaretBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchCaretBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchCaretBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchCaretBlendMode(string value) => new(value);

    internal class AnnotationPatchCaretBlendModeSerializer
        : JsonConverter<AnnotationPatchCaretBlendMode>
    {
        public override AnnotationPatchCaretBlendMode Read(
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
            return new AnnotationPatchCaretBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchCaretBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchCaretBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchCaretBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchCaretBlendMode value,
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
