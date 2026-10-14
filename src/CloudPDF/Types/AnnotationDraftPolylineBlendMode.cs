using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftPolylineBlendMode.AnnotationDraftPolylineBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftPolylineBlendMode : IStringEnum
{
    public static readonly AnnotationDraftPolylineBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftPolylineBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftPolylineBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftPolylineBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftPolylineBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftPolylineBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftPolylineBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftPolylineBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftPolylineBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftPolylineBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftPolylineBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftPolylineBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftPolylineBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftPolylineBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftPolylineBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftPolylineBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftPolylineBlendMode(string value)
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
    public static AnnotationDraftPolylineBlendMode FromCustom(string value)
    {
        return new AnnotationDraftPolylineBlendMode(value);
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

    public static bool operator ==(AnnotationDraftPolylineBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftPolylineBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftPolylineBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftPolylineBlendMode(string value) => new(value);

    internal class AnnotationDraftPolylineBlendModeSerializer
        : JsonConverter<AnnotationDraftPolylineBlendMode>
    {
        public override AnnotationDraftPolylineBlendMode Read(
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
            return new AnnotationDraftPolylineBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolylineBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftPolylineBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineBlendMode value,
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
