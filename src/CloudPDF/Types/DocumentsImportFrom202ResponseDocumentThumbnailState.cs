using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsImportFrom202ResponseDocumentThumbnailState.DocumentsImportFrom202ResponseDocumentThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsImportFrom202ResponseDocumentThumbnailState : IStringEnum
{
    public static readonly DocumentsImportFrom202ResponseDocumentThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsImportFrom202ResponseDocumentThumbnailState Ready = new(
        Values.Ready
    );

    public static readonly DocumentsImportFrom202ResponseDocumentThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsImportFrom202ResponseDocumentThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsImportFrom202ResponseDocumentThumbnailState(string value)
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
    public static DocumentsImportFrom202ResponseDocumentThumbnailState FromCustom(string value)
    {
        return new DocumentsImportFrom202ResponseDocumentThumbnailState(value);
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
        DocumentsImportFrom202ResponseDocumentThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsImportFrom202ResponseDocumentThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsImportFrom202ResponseDocumentThumbnailState value
    ) => value.Value;

    public static explicit operator DocumentsImportFrom202ResponseDocumentThumbnailState(
        string value
    ) => new(value);

    internal class DocumentsImportFrom202ResponseDocumentThumbnailStateSerializer
        : JsonConverter<DocumentsImportFrom202ResponseDocumentThumbnailState>
    {
        public override DocumentsImportFrom202ResponseDocumentThumbnailState Read(
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
            return new DocumentsImportFrom202ResponseDocumentThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsImportFrom202ResponseDocumentThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsImportFrom202ResponseDocumentThumbnailState ReadAsPropertyName(
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
            return new DocumentsImportFrom202ResponseDocumentThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsImportFrom202ResponseDocumentThumbnailState value,
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
