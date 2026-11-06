using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfActionNodeSubmitFormPayloadMethod.PdfActionNodeSubmitFormPayloadMethodSerializer)
)]
[Serializable]
public readonly record struct PdfActionNodeSubmitFormPayloadMethod : IStringEnum
{
    public static readonly PdfActionNodeSubmitFormPayloadMethod Post = new(Values.Post);

    public static readonly PdfActionNodeSubmitFormPayloadMethod Get = new(Values.Get);

    public PdfActionNodeSubmitFormPayloadMethod(string value)
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
    public static PdfActionNodeSubmitFormPayloadMethod FromCustom(string value)
    {
        return new PdfActionNodeSubmitFormPayloadMethod(value);
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

    public static bool operator ==(PdfActionNodeSubmitFormPayloadMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfActionNodeSubmitFormPayloadMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfActionNodeSubmitFormPayloadMethod value) =>
        value.Value;

    public static explicit operator PdfActionNodeSubmitFormPayloadMethod(string value) =>
        new(value);

    internal class PdfActionNodeSubmitFormPayloadMethodSerializer
        : JsonConverter<PdfActionNodeSubmitFormPayloadMethod>
    {
        public override PdfActionNodeSubmitFormPayloadMethod Read(
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
            return new PdfActionNodeSubmitFormPayloadMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionNodeSubmitFormPayloadMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfActionNodeSubmitFormPayloadMethod ReadAsPropertyName(
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
            return new PdfActionNodeSubmitFormPayloadMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionNodeSubmitFormPayloadMethod value,
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
        public const string Post = "post";

        public const string Get = "get";
    }
}
