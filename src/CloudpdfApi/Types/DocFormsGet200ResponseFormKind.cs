using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFormKind.DocFormsGet200ResponseFormKindSerializer))]
[Serializable]
public readonly record struct DocFormsGet200ResponseFormKind : IStringEnum
{
    public static readonly DocFormsGet200ResponseFormKind None = new(Values.None);

    public static readonly DocFormsGet200ResponseFormKind Acroform = new(Values.Acroform);

    public static readonly DocFormsGet200ResponseFormKind Xfa = new(Values.Xfa);

    public DocFormsGet200ResponseFormKind(string value)
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
    public static DocFormsGet200ResponseFormKind FromCustom(string value)
    {
        return new DocFormsGet200ResponseFormKind(value);
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

    public static bool operator ==(DocFormsGet200ResponseFormKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocFormsGet200ResponseFormKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsGet200ResponseFormKind value) => value.Value;

    public static explicit operator DocFormsGet200ResponseFormKind(string value) => new(value);

    internal class DocFormsGet200ResponseFormKindSerializer
        : JsonConverter<DocFormsGet200ResponseFormKind>
    {
        public override DocFormsGet200ResponseFormKind Read(
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
            return new DocFormsGet200ResponseFormKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFormKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFormKind ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFormKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFormKind value,
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
        public const string None = "none";

        public const string Acroform = "acroform";

        public const string Xfa = "xfa";
    }
}
