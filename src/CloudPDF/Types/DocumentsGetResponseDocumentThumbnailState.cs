using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsGetResponseDocumentThumbnailState.DocumentsGetResponseDocumentThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsGetResponseDocumentThumbnailState : IStringEnum
{
    public static readonly DocumentsGetResponseDocumentThumbnailState Pending = new(Values.Pending);

    public static readonly DocumentsGetResponseDocumentThumbnailState Ready = new(Values.Ready);

    public static readonly DocumentsGetResponseDocumentThumbnailState Locked = new(Values.Locked);

    public static readonly DocumentsGetResponseDocumentThumbnailState Failed = new(Values.Failed);

    public DocumentsGetResponseDocumentThumbnailState(string value)
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
    public static DocumentsGetResponseDocumentThumbnailState FromCustom(string value)
    {
        return new DocumentsGetResponseDocumentThumbnailState(value);
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
        DocumentsGetResponseDocumentThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsGetResponseDocumentThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsGetResponseDocumentThumbnailState value) =>
        value.Value;

    public static explicit operator DocumentsGetResponseDocumentThumbnailState(string value) =>
        new(value);

    internal class DocumentsGetResponseDocumentThumbnailStateSerializer
        : JsonConverter<DocumentsGetResponseDocumentThumbnailState>
    {
        public override DocumentsGetResponseDocumentThumbnailState Read(
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
            return new DocumentsGetResponseDocumentThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsGetResponseDocumentThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsGetResponseDocumentThumbnailState ReadAsPropertyName(
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
            return new DocumentsGetResponseDocumentThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsGetResponseDocumentThumbnailState value,
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
        public const string Pending = "pending";

        public const string Ready = "ready";

        public const string Locked = "locked";

        public const string Failed = "failed";
    }
}
