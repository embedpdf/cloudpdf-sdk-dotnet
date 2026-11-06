using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsCommitResponseDocumentState.DocumentsCommitResponseDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsCommitResponseDocumentState : IStringEnum
{
    public static readonly DocumentsCommitResponseDocumentState Pending = new(Values.Pending);

    public static readonly DocumentsCommitResponseDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsCommitResponseDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsCommitResponseDocumentState Deleting = new(Values.Deleting);

    public DocumentsCommitResponseDocumentState(string value)
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
    public static DocumentsCommitResponseDocumentState FromCustom(string value)
    {
        return new DocumentsCommitResponseDocumentState(value);
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

    public static bool operator ==(DocumentsCommitResponseDocumentState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsCommitResponseDocumentState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsCommitResponseDocumentState value) =>
        value.Value;

    public static explicit operator DocumentsCommitResponseDocumentState(string value) =>
        new(value);

    internal class DocumentsCommitResponseDocumentStateSerializer
        : JsonConverter<DocumentsCommitResponseDocumentState>
    {
        public override DocumentsCommitResponseDocumentState Read(
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
            return new DocumentsCommitResponseDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsCommitResponseDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsCommitResponseDocumentState ReadAsPropertyName(
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
            return new DocumentsCommitResponseDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsCommitResponseDocumentState value,
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
