using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsInitResponseDedupedDocumentState.DocumentsInitResponseDedupedDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsInitResponseDedupedDocumentState : IStringEnum
{
    public static readonly DocumentsInitResponseDedupedDocumentState Pending = new(Values.Pending);

    public static readonly DocumentsInitResponseDedupedDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsInitResponseDedupedDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsInitResponseDedupedDocumentState Deleting = new(
        Values.Deleting
    );

    public DocumentsInitResponseDedupedDocumentState(string value)
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
    public static DocumentsInitResponseDedupedDocumentState FromCustom(string value)
    {
        return new DocumentsInitResponseDedupedDocumentState(value);
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
        DocumentsInitResponseDedupedDocumentState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsInitResponseDedupedDocumentState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsInitResponseDedupedDocumentState value) =>
        value.Value;

    public static explicit operator DocumentsInitResponseDedupedDocumentState(string value) =>
        new(value);

    internal class DocumentsInitResponseDedupedDocumentStateSerializer
        : JsonConverter<DocumentsInitResponseDedupedDocumentState>
    {
        public override DocumentsInitResponseDedupedDocumentState Read(
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
            return new DocumentsInitResponseDedupedDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInitResponseDedupedDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInitResponseDedupedDocumentState ReadAsPropertyName(
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
            return new DocumentsInitResponseDedupedDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInitResponseDedupedDocumentState value,
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
