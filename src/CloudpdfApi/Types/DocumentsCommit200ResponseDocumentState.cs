using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocumentsCommit200ResponseDocumentState.DocumentsCommit200ResponseDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsCommit200ResponseDocumentState : IStringEnum
{
    public static readonly DocumentsCommit200ResponseDocumentState Pending = new(Values.Pending);

    public static readonly DocumentsCommit200ResponseDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsCommit200ResponseDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsCommit200ResponseDocumentState Deleting = new(Values.Deleting);

    public DocumentsCommit200ResponseDocumentState(string value)
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
    public static DocumentsCommit200ResponseDocumentState FromCustom(string value)
    {
        return new DocumentsCommit200ResponseDocumentState(value);
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

    public static bool operator ==(DocumentsCommit200ResponseDocumentState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsCommit200ResponseDocumentState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsCommit200ResponseDocumentState value) =>
        value.Value;

    public static explicit operator DocumentsCommit200ResponseDocumentState(string value) =>
        new(value);

    internal class DocumentsCommit200ResponseDocumentStateSerializer
        : JsonConverter<DocumentsCommit200ResponseDocumentState>
    {
        public override DocumentsCommit200ResponseDocumentState Read(
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
            return new DocumentsCommit200ResponseDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsCommit200ResponseDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsCommit200ResponseDocumentState ReadAsPropertyName(
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
            return new DocumentsCommit200ResponseDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsCommit200ResponseDocumentState value,
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
