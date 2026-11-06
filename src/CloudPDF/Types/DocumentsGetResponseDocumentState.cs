using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsGetResponseDocumentState.DocumentsGetResponseDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsGetResponseDocumentState : IStringEnum
{
    public static readonly DocumentsGetResponseDocumentState Pending = new(Values.Pending);

    public static readonly DocumentsGetResponseDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsGetResponseDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsGetResponseDocumentState Deleting = new(Values.Deleting);

    public DocumentsGetResponseDocumentState(string value)
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
    public static DocumentsGetResponseDocumentState FromCustom(string value)
    {
        return new DocumentsGetResponseDocumentState(value);
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

    public static bool operator ==(DocumentsGetResponseDocumentState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsGetResponseDocumentState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsGetResponseDocumentState value) => value.Value;

    public static explicit operator DocumentsGetResponseDocumentState(string value) => new(value);

    internal class DocumentsGetResponseDocumentStateSerializer
        : JsonConverter<DocumentsGetResponseDocumentState>
    {
        public override DocumentsGetResponseDocumentState Read(
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
            return new DocumentsGetResponseDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsGetResponseDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsGetResponseDocumentState ReadAsPropertyName(
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
            return new DocumentsGetResponseDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsGetResponseDocumentState value,
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
