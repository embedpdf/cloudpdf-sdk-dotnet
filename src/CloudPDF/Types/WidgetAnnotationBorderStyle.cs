using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationBorderStyle.WidgetAnnotationBorderStyleSerializer))]
[Serializable]
public readonly record struct WidgetAnnotationBorderStyle : IStringEnum
{
    public static readonly WidgetAnnotationBorderStyle Solid = new(Values.Solid);

    public static readonly WidgetAnnotationBorderStyle Dashed = new(Values.Dashed);

    public static readonly WidgetAnnotationBorderStyle Beveled = new(Values.Beveled);

    public static readonly WidgetAnnotationBorderStyle Inset = new(Values.Inset);

    public static readonly WidgetAnnotationBorderStyle Underline = new(Values.Underline);

    public WidgetAnnotationBorderStyle(string value)
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
    public static WidgetAnnotationBorderStyle FromCustom(string value)
    {
        return new WidgetAnnotationBorderStyle(value);
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

    public static bool operator ==(WidgetAnnotationBorderStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationBorderStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationBorderStyle value) => value.Value;

    public static explicit operator WidgetAnnotationBorderStyle(string value) => new(value);

    internal class WidgetAnnotationBorderStyleSerializer
        : JsonConverter<WidgetAnnotationBorderStyle>
    {
        public override WidgetAnnotationBorderStyle Read(
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
            return new WidgetAnnotationBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationBorderStyle ReadAsPropertyName(
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
            return new WidgetAnnotationBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationBorderStyle value,
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
        public const string Solid = "solid";

        public const string Dashed = "dashed";

        public const string Beveled = "beveled";

        public const string Inset = "inset";

        public const string Underline = "underline";
    }
}
