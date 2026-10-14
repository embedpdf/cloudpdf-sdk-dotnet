using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchRedactTextAlign.AnnotationPatchRedactTextAlignSerializer))]
[Serializable]
public readonly record struct AnnotationPatchRedactTextAlign : IStringEnum
{
    public static readonly AnnotationPatchRedactTextAlign Left = new(Values.Left);

    public static readonly AnnotationPatchRedactTextAlign Center = new(Values.Center);

    public static readonly AnnotationPatchRedactTextAlign Right = new(Values.Right);

    public AnnotationPatchRedactTextAlign(string value)
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
    public static AnnotationPatchRedactTextAlign FromCustom(string value)
    {
        return new AnnotationPatchRedactTextAlign(value);
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

    public static bool operator ==(AnnotationPatchRedactTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchRedactTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchRedactTextAlign value) => value.Value;

    public static explicit operator AnnotationPatchRedactTextAlign(string value) => new(value);

    internal class AnnotationPatchRedactTextAlignSerializer
        : JsonConverter<AnnotationPatchRedactTextAlign>
    {
        public override AnnotationPatchRedactTextAlign Read(
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
            return new AnnotationPatchRedactTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchRedactTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchRedactTextAlign ReadAsPropertyName(
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
            return new AnnotationPatchRedactTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchRedactTextAlign value,
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
