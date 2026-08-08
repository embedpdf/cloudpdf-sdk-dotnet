using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocumentsInit200ResponseDedupedDocumentState.DocumentsInit200ResponseDedupedDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsInit200ResponseDedupedDocumentState : IStringEnum
{
    public static readonly DocumentsInit200ResponseDedupedDocumentState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsInit200ResponseDedupedDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsInit200ResponseDedupedDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsInit200ResponseDedupedDocumentState Deleting = new(
        Values.Deleting
    );

    public DocumentsInit200ResponseDedupedDocumentState(string value)
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
    public static DocumentsInit200ResponseDedupedDocumentState FromCustom(string value)
    {
        return new DocumentsInit200ResponseDedupedDocumentState(value);
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
        DocumentsInit200ResponseDedupedDocumentState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsInit200ResponseDedupedDocumentState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsInit200ResponseDedupedDocumentState value) =>
        value.Value;

    public static explicit operator DocumentsInit200ResponseDedupedDocumentState(string value) =>
        new(value);

    internal class DocumentsInit200ResponseDedupedDocumentStateSerializer
        : JsonConverter<DocumentsInit200ResponseDedupedDocumentState>
    {
        public override DocumentsInit200ResponseDedupedDocumentState Read(
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
            return new DocumentsInit200ResponseDedupedDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseDedupedDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInit200ResponseDedupedDocumentState ReadAsPropertyName(
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
            return new DocumentsInit200ResponseDedupedDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseDedupedDocumentState value,
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

        public const string Failed = "failed";

        public const string Deleting = "deleting";
    }
}
