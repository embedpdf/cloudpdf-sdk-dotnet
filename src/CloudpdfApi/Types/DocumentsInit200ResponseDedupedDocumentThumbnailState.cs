using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocumentsInit200ResponseDedupedDocumentThumbnailState.DocumentsInit200ResponseDedupedDocumentThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsInit200ResponseDedupedDocumentThumbnailState : IStringEnum
{
    public static readonly DocumentsInit200ResponseDedupedDocumentThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsInit200ResponseDedupedDocumentThumbnailState Ready = new(
        Values.Ready
    );

    public static readonly DocumentsInit200ResponseDedupedDocumentThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsInit200ResponseDedupedDocumentThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsInit200ResponseDedupedDocumentThumbnailState(string value)
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
    public static DocumentsInit200ResponseDedupedDocumentThumbnailState FromCustom(string value)
    {
        return new DocumentsInit200ResponseDedupedDocumentThumbnailState(value);
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
        DocumentsInit200ResponseDedupedDocumentThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsInit200ResponseDedupedDocumentThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsInit200ResponseDedupedDocumentThumbnailState value
    ) => value.Value;

    public static explicit operator DocumentsInit200ResponseDedupedDocumentThumbnailState(
        string value
    ) => new(value);

    internal class DocumentsInit200ResponseDedupedDocumentThumbnailStateSerializer
        : JsonConverter<DocumentsInit200ResponseDedupedDocumentThumbnailState>
    {
        public override DocumentsInit200ResponseDedupedDocumentThumbnailState Read(
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
            return new DocumentsInit200ResponseDedupedDocumentThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseDedupedDocumentThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInit200ResponseDedupedDocumentThumbnailState ReadAsPropertyName(
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
            return new DocumentsInit200ResponseDedupedDocumentThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseDedupedDocumentThumbnailState value,
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
