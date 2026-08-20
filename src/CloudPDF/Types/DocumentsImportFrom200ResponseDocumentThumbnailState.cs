using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsImportFrom200ResponseDocumentThumbnailState.DocumentsImportFrom200ResponseDocumentThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsImportFrom200ResponseDocumentThumbnailState : IStringEnum
{
    public static readonly DocumentsImportFrom200ResponseDocumentThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsImportFrom200ResponseDocumentThumbnailState Ready = new(
        Values.Ready
    );

    public static readonly DocumentsImportFrom200ResponseDocumentThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsImportFrom200ResponseDocumentThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsImportFrom200ResponseDocumentThumbnailState(string value)
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
    public static DocumentsImportFrom200ResponseDocumentThumbnailState FromCustom(string value)
    {
        return new DocumentsImportFrom200ResponseDocumentThumbnailState(value);
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
        DocumentsImportFrom200ResponseDocumentThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsImportFrom200ResponseDocumentThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsImportFrom200ResponseDocumentThumbnailState value
    ) => value.Value;

    public static explicit operator DocumentsImportFrom200ResponseDocumentThumbnailState(
        string value
    ) => new(value);

    internal class DocumentsImportFrom200ResponseDocumentThumbnailStateSerializer
        : JsonConverter<DocumentsImportFrom200ResponseDocumentThumbnailState>
    {
        public override DocumentsImportFrom200ResponseDocumentThumbnailState Read(
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
            return new DocumentsImportFrom200ResponseDocumentThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsImportFrom200ResponseDocumentThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsImportFrom200ResponseDocumentThumbnailState ReadAsPropertyName(
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
            return new DocumentsImportFrom200ResponseDocumentThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsImportFrom200ResponseDocumentThumbnailState value,
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
