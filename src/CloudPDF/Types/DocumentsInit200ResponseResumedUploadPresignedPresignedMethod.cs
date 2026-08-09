using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsInit200ResponseResumedUploadPresignedPresignedMethod.DocumentsInit200ResponseResumedUploadPresignedPresignedMethodSerializer)
)]
[Serializable]
public readonly record struct DocumentsInit200ResponseResumedUploadPresignedPresignedMethod
    : IStringEnum
{
    public static readonly DocumentsInit200ResponseResumedUploadPresignedPresignedMethod Put = new(
        Values.Put
    );

    public DocumentsInit200ResponseResumedUploadPresignedPresignedMethod(string value)
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
    public static DocumentsInit200ResponseResumedUploadPresignedPresignedMethod FromCustom(
        string value
    )
    {
        return new DocumentsInit200ResponseResumedUploadPresignedPresignedMethod(value);
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
        DocumentsInit200ResponseResumedUploadPresignedPresignedMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsInit200ResponseResumedUploadPresignedPresignedMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsInit200ResponseResumedUploadPresignedPresignedMethod value
    ) => value.Value;

    public static explicit operator DocumentsInit200ResponseResumedUploadPresignedPresignedMethod(
        string value
    ) => new(value);

    internal class DocumentsInit200ResponseResumedUploadPresignedPresignedMethodSerializer
        : JsonConverter<DocumentsInit200ResponseResumedUploadPresignedPresignedMethod>
    {
        public override DocumentsInit200ResponseResumedUploadPresignedPresignedMethod Read(
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
            return new DocumentsInit200ResponseResumedUploadPresignedPresignedMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseResumedUploadPresignedPresignedMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInit200ResponseResumedUploadPresignedPresignedMethod ReadAsPropertyName(
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
            return new DocumentsInit200ResponseResumedUploadPresignedPresignedMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseResumedUploadPresignedPresignedMethod value,
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
