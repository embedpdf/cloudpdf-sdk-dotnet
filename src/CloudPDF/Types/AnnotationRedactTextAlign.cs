using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationRedactTextAlign.AnnotationRedactTextAlignSerializer))]
[Serializable]
public readonly record struct AnnotationRedactTextAlign : IStringEnum
{
    public static readonly AnnotationRedactTextAlign Left = new(Values.Left);

    public static readonly AnnotationRedactTextAlign Center = new(Values.Center);

    public static readonly AnnotationRedactTextAlign Right = new(Values.Right);

    public AnnotationRedactTextAlign(string value)
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
    public static AnnotationRedactTextAlign FromCustom(string value)
    {
        return new AnnotationRedactTextAlign(value);
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

    public static bool operator ==(AnnotationRedactTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationRedactTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationRedactTextAlign value) => value.Value;

    public static explicit operator AnnotationRedactTextAlign(string value) => new(value);

    internal class AnnotationRedactTextAlignSerializer : JsonConverter<AnnotationRedactTextAlign>
    {
        public override AnnotationRedactTextAlign Read(
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
            return new AnnotationRedactTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationRedactTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationRedactTextAlign ReadAsPropertyName(
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
            return new AnnotationRedactTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationRedactTextAlign value,
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
    }
}
