using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsCommit200ResponseDocumentThumbnailState.DocumentsCommit200ResponseDocumentThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsCommit200ResponseDocumentThumbnailState : IStringEnum
{
    public static readonly DocumentsCommit200ResponseDocumentThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsCommit200ResponseDocumentThumbnailState Ready = new(
        Values.Ready
    );

    public static readonly DocumentsCommit200ResponseDocumentThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsCommit200ResponseDocumentThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsCommit200ResponseDocumentThumbnailState(string value)
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
    public static DocumentsCommit200ResponseDocumentThumbnailState FromCustom(string value)
    {
        return new DocumentsCommit200ResponseDocumentThumbnailState(value);
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
        DocumentsCommit200ResponseDocumentThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsCommit200ResponseDocumentThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsCommit200ResponseDocumentThumbnailState value
    ) => value.Value;

    public static explicit operator DocumentsCommit200ResponseDocumentThumbnailState(
        string value
    ) => new(value);

    internal class DocumentsCommit200ResponseDocumentThumbnailStateSerializer
        : JsonConverter<DocumentsCommit200ResponseDocumentThumbnailState>
    {
        public override DocumentsCommit200ResponseDocumentThumbnailState Read(
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
            return new DocumentsCommit200ResponseDocumentThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsCommit200ResponseDocumentThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsCommit200ResponseDocumentThumbnailState ReadAsPropertyName(
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
            return new DocumentsCommit200ResponseDocumentThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsCommit200ResponseDocumentThumbnailState value,
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
