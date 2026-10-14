using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsList200ResponseFormKind.DocFormsList200ResponseFormKindSerializer))]
[Serializable]
public readonly record struct DocFormsList200ResponseFormKind : IStringEnum
{
    public static readonly DocFormsList200ResponseFormKind None = new(Values.None);

    public static readonly DocFormsList200ResponseFormKind Acroform = new(Values.Acroform);

    public static readonly DocFormsList200ResponseFormKind Xfa = new(Values.Xfa);

    public DocFormsList200ResponseFormKind(string value)
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
    public static DocFormsList200ResponseFormKind FromCustom(string value)
    {
        return new DocFormsList200ResponseFormKind(value);
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

    public static bool operator ==(DocFormsList200ResponseFormKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocFormsList200ResponseFormKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsList200ResponseFormKind value) => value.Value;

    public static explicit operator DocFormsList200ResponseFormKind(string value) => new(value);

    internal class DocFormsList200ResponseFormKindSerializer
        : JsonConverter<DocFormsList200ResponseFormKind>
    {
        public override DocFormsList200ResponseFormKind Read(
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
            return new DocFormsList200ResponseFormKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsList200ResponseFormKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsList200ResponseFormKind ReadAsPropertyName(
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
            return new DocFormsList200ResponseFormKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsList200ResponseFormKind value,
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
