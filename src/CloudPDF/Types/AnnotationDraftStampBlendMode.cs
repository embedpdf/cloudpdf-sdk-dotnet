using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftStampBlendMode.AnnotationDraftStampBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftStampBlendMode : IStringEnum
{
    public static readonly AnnotationDraftStampBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftStampBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftStampBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftStampBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftStampBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftStampBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftStampBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftStampBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftStampBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftStampBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftStampBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftStampBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftStampBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftStampBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftStampBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftStampBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftStampBlendMode(string value)
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
    public static AnnotationDraftStampBlendMode FromCustom(string value)
    {
        return new AnnotationDraftStampBlendMode(value);
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

    public static bool operator ==(AnnotationDraftStampBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftStampBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftStampBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftStampBlendMode(string value) => new(value);

    internal class AnnotationDraftStampBlendModeSerializer
        : JsonConverter<AnnotationDraftStampBlendMode>
    {
        public override AnnotationDraftStampBlendMode Read(
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
            return new AnnotationDraftStampBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftStampBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftStampBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftStampBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftStampBlendMode value,
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
