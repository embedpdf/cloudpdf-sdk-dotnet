using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod.DocumentsInit200ResponseCreatedUploadPresignedPresignedMethodSerializer)
)]
[Serializable]
public readonly record struct DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod
    : IStringEnum
{
    public static readonly DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod Put = new(
        Values.Put
    );

    public DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod(string value)
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
    public static DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod FromCustom(
        string value
    )
    {
        return new DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod(value);
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

    public static bool operator ==(
        DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod value
    ) => value.Value;

    public static explicit operator DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod(
        string value
    ) => new(value);

    internal class DocumentsInit200ResponseCreatedUploadPresignedPresignedMethodSerializer
        : JsonConverter<DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod>
    {
        public override DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod Read(
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
            return new DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod ReadAsPropertyName(
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
            return new DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseCreatedUploadPresignedPresignedMethod value,
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
        public const string Put = "PUT";
    }
}
