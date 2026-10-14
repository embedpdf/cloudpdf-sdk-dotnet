using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftRedactTextAlign.AnnotationDraftRedactTextAlignSerializer))]
[Serializable]
public readonly record struct AnnotationDraftRedactTextAlign : IStringEnum
{
    public static readonly AnnotationDraftRedactTextAlign Left = new(Values.Left);

    public static readonly AnnotationDraftRedactTextAlign Center = new(Values.Center);

    public static readonly AnnotationDraftRedactTextAlign Right = new(Values.Right);

    public AnnotationDraftRedactTextAlign(string value)
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
    public static AnnotationDraftRedactTextAlign FromCustom(string value)
    {
        return new AnnotationDraftRedactTextAlign(value);
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

    public static bool operator ==(AnnotationDraftRedactTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftRedactTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftRedactTextAlign value) => value.Value;

    public static explicit operator AnnotationDraftRedactTextAlign(string value) => new(value);

    internal class AnnotationDraftRedactTextAlignSerializer
        : JsonConverter<AnnotationDraftRedactTextAlign>
    {
        public override AnnotationDraftRedactTextAlign Read(
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
            return new AnnotationDraftRedactTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftRedactTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftRedactTextAlign ReadAsPropertyName(
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
            return new AnnotationDraftRedactTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftRedactTextAlign value,
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
