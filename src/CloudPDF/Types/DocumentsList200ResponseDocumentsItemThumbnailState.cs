using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsList200ResponseDocumentsItemThumbnailState.DocumentsList200ResponseDocumentsItemThumbnailStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsList200ResponseDocumentsItemThumbnailState : IStringEnum
{
    public static readonly DocumentsList200ResponseDocumentsItemThumbnailState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsList200ResponseDocumentsItemThumbnailState Ready = new(
        Values.Ready
    );

    public static readonly DocumentsList200ResponseDocumentsItemThumbnailState Locked = new(
        Values.Locked
    );

    public static readonly DocumentsList200ResponseDocumentsItemThumbnailState Failed = new(
        Values.Failed
    );

    public DocumentsList200ResponseDocumentsItemThumbnailState(string value)
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
    public static DocumentsList200ResponseDocumentsItemThumbnailState FromCustom(string value)
    {
        return new DocumentsList200ResponseDocumentsItemThumbnailState(value);
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
        DocumentsList200ResponseDocumentsItemThumbnailState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsList200ResponseDocumentsItemThumbnailState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsList200ResponseDocumentsItemThumbnailState value
    ) => value.Value;

    public static explicit operator DocumentsList200ResponseDocumentsItemThumbnailState(
        string value
    ) => new(value);

    internal class DocumentsList200ResponseDocumentsItemThumbnailStateSerializer
        : JsonConverter<DocumentsList200ResponseDocumentsItemThumbnailState>
    {
        public override DocumentsList200ResponseDocumentsItemThumbnailState Read(
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
            return new DocumentsList200ResponseDocumentsItemThumbnailState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsList200ResponseDocumentsItemThumbnailState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsList200ResponseDocumentsItemThumbnailState ReadAsPropertyName(
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
            return new DocumentsList200ResponseDocumentsItemThumbnailState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsList200ResponseDocumentsItemThumbnailState value,
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
