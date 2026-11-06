using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsUpdateResponseDocumentThumbnailState.DocumentsUpdateResponseDocumentThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsUpdateResponseDocumentThumbnailState : IStringEnum
{
    public static readonly DocumentsUpdateResponseDocumentThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsUpdateResponseDocumentThumbnailState Ready = new(Values.Ready);

    public static readonly DocumentsUpdateResponseDocumentThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsUpdateResponseDocumentThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsUpdateResponseDocumentThumbnailState(string value)
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
    public static DocumentsUpdateResponseDocumentThumbnailState FromCustom(string value)
    {
        return new DocumentsUpdateResponseDocumentThumbnailState(value);
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
        DocumentsUpdateResponseDocumentThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsUpdateResponseDocumentThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsUpdateResponseDocumentThumbnailState value) =>
        value.Value;

    public static explicit operator DocumentsUpdateResponseDocumentThumbnailState(string value) =>
        new(value);

    internal class DocumentsUpdateResponseDocumentThumbnailStateSerializer
        : JsonConverter<DocumentsUpdateResponseDocumentThumbnailState>
    {
        public override DocumentsUpdateResponseDocumentThumbnailState Read(
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
            return new DocumentsUpdateResponseDocumentThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsUpdateResponseDocumentThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsUpdateResponseDocumentThumbnailState ReadAsPropertyName(
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
            return new DocumentsUpdateResponseDocumentThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsUpdateResponseDocumentThumbnailState value,
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
