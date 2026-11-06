using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsListResponseDocumentsItemState.DocumentsListResponseDocumentsItemStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsListResponseDocumentsItemState : IStringEnum
{
    public static readonly DocumentsListResponseDocumentsItemState Pending = new(Values.Pending);

    public static readonly DocumentsListResponseDocumentsItemState Ready = new(Values.Ready);

    public static readonly DocumentsListResponseDocumentsItemState Failed = new(Values.Failed);

    public static readonly DocumentsListResponseDocumentsItemState Deleting = new(Values.Deleting);

    public DocumentsListResponseDocumentsItemState(string value)
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
    public static DocumentsListResponseDocumentsItemState FromCustom(string value)
    {
        return new DocumentsListResponseDocumentsItemState(value);
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

    public static bool operator ==(DocumentsListResponseDocumentsItemState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsListResponseDocumentsItemState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsListResponseDocumentsItemState value) =>
        value.Value;

    public static explicit operator DocumentsListResponseDocumentsItemState(string value) =>
        new(value);

    internal class DocumentsListResponseDocumentsItemStateSerializer
        : JsonConverter<DocumentsListResponseDocumentsItemState>
    {
        public override DocumentsListResponseDocumentsItemState Read(
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
            return new DocumentsListResponseDocumentsItemState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsListResponseDocumentsItemState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsListResponseDocumentsItemState ReadAsPropertyName(
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
            return new DocumentsListResponseDocumentsItemState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsListResponseDocumentsItemState value,
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
