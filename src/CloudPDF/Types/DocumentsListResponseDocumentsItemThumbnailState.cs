using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsListResponseDocumentsItemThumbnailState.DocumentsListResponseDocumentsItemThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsListResponseDocumentsItemThumbnailState : IStringEnum
{
    public static readonly DocumentsListResponseDocumentsItemThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsListResponseDocumentsItemThumbnailState Ready = new(
        Values.Ready
    );

    public static readonly DocumentsListResponseDocumentsItemThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsListResponseDocumentsItemThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsListResponseDocumentsItemThumbnailState(string value)
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
    public static DocumentsListResponseDocumentsItemThumbnailState FromCustom(string value)
    {
        return new DocumentsListResponseDocumentsItemThumbnailState(value);
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
        DocumentsListResponseDocumentsItemThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsListResponseDocumentsItemThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsListResponseDocumentsItemThumbnailState value
    ) => value.Value;

    public static explicit operator DocumentsListResponseDocumentsItemThumbnailState(
        string value
    ) => new(value);

    internal class DocumentsListResponseDocumentsItemThumbnailStateSerializer
        : JsonConverter<DocumentsListResponseDocumentsItemThumbnailState>
    {
        public override DocumentsListResponseDocumentsItemThumbnailState Read(
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
            return new DocumentsListResponseDocumentsItemThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsListResponseDocumentsItemThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsListResponseDocumentsItemThumbnailState ReadAsPropertyName(
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
            return new DocumentsListResponseDocumentsItemThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsListResponseDocumentsItemThumbnailState value,
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
