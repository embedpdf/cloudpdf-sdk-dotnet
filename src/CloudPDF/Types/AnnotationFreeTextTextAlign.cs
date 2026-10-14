using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationFreeTextTextAlign.AnnotationFreeTextTextAlignSerializer))]
[Serializable]
public readonly record struct AnnotationFreeTextTextAlign : IStringEnum
{
    public static readonly AnnotationFreeTextTextAlign Left = new(Values.Left);

    public static readonly AnnotationFreeTextTextAlign Center = new(Values.Center);

    public static readonly AnnotationFreeTextTextAlign Right = new(Values.Right);

    public static readonly AnnotationFreeTextTextAlign Justify = new(Values.Justify);

    public AnnotationFreeTextTextAlign(string value)
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
    public static AnnotationFreeTextTextAlign FromCustom(string value)
    {
        return new AnnotationFreeTextTextAlign(value);
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

    public static bool operator ==(AnnotationFreeTextTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFreeTextTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextTextAlign value) => value.Value;

    public static explicit operator AnnotationFreeTextTextAlign(string value) => new(value);

    internal class AnnotationFreeTextTextAlignSerializer
        : JsonConverter<AnnotationFreeTextTextAlign>
    {
        public override AnnotationFreeTextTextAlign Read(
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
            return new AnnotationFreeTextTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextTextAlign ReadAsPropertyName(
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
            return new AnnotationFreeTextTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextTextAlign value,
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
        public const string Left = "left";

        public const string Center = "center";

        public const string Right = "right";

        public const string Justify = "justify";
    }
}
