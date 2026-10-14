using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftCircleBlendMode.AnnotationDraftCircleBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftCircleBlendMode : IStringEnum
{
    public static readonly AnnotationDraftCircleBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftCircleBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftCircleBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftCircleBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftCircleBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftCircleBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftCircleBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftCircleBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftCircleBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftCircleBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftCircleBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftCircleBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftCircleBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftCircleBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftCircleBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftCircleBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftCircleBlendMode(string value)
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
    public static AnnotationDraftCircleBlendMode FromCustom(string value)
    {
        return new AnnotationDraftCircleBlendMode(value);
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

    public static bool operator ==(AnnotationDraftCircleBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftCircleBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftCircleBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftCircleBlendMode(string value) => new(value);

    internal class AnnotationDraftCircleBlendModeSerializer
        : JsonConverter<AnnotationDraftCircleBlendMode>
    {
        public override AnnotationDraftCircleBlendMode Read(
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
            return new AnnotationDraftCircleBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftCircleBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftCircleBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftCircleBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftCircleBlendMode value,
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
