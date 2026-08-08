using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocumentsGet200ResponseDocumentThumbnailState.DocumentsGet200ResponseDocumentThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsGet200ResponseDocumentThumbnailState : IStringEnum
{
    public static readonly DocumentsGet200ResponseDocumentThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsGet200ResponseDocumentThumbnailState Ready = new(Values.Ready);

    public static readonly DocumentsGet200ResponseDocumentThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsGet200ResponseDocumentThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsGet200ResponseDocumentThumbnailState(string value)
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
    public static DocumentsGet200ResponseDocumentThumbnailState FromCustom(string value)
    {
        return new DocumentsGet200ResponseDocumentThumbnailState(value);
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
        DocumentsGet200ResponseDocumentThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsGet200ResponseDocumentThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsGet200ResponseDocumentThumbnailState value) =>
        value.Value;

    public static explicit operator DocumentsGet200ResponseDocumentThumbnailState(string value) =>
        new(value);

    internal class DocumentsGet200ResponseDocumentThumbnailStateSerializer
        : JsonConverter<DocumentsGet200ResponseDocumentThumbnailState>
    {
        public override DocumentsGet200ResponseDocumentThumbnailState Read(
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
            return new DocumentsGet200ResponseDocumentThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsGet200ResponseDocumentThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsGet200ResponseDocumentThumbnailState ReadAsPropertyName(
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
            return new DocumentsGet200ResponseDocumentThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsGet200ResponseDocumentThumbnailState value,
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
