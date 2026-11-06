using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsListResponseFormKind.DocFormsListResponseFormKindSerializer))]
[Serializable]
public readonly record struct DocFormsListResponseFormKind : IStringEnum
{
    public static readonly DocFormsListResponseFormKind None = new(Values.None);

    public static readonly DocFormsListResponseFormKind Acroform = new(Values.Acroform);

    public static readonly DocFormsListResponseFormKind Xfa = new(Values.Xfa);

    public DocFormsListResponseFormKind(string value)
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
    public static DocFormsListResponseFormKind FromCustom(string value)
    {
        return new DocFormsListResponseFormKind(value);
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

    public static bool operator ==(DocFormsListResponseFormKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocFormsListResponseFormKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsListResponseFormKind value) => value.Value;

    public static explicit operator DocFormsListResponseFormKind(string value) => new(value);

    internal class DocFormsListResponseFormKindSerializer
        : JsonConverter<DocFormsListResponseFormKind>
    {
        public override DocFormsListResponseFormKind Read(
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
            return new DocFormsListResponseFormKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsListResponseFormKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsListResponseFormKind ReadAsPropertyName(
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
            return new DocFormsListResponseFormKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsListResponseFormKind value,
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
