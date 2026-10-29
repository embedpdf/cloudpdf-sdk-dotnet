using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ListDocumentsRequestSort.ListDocumentsRequestSortSerializer))]
[Serializable]
public readonly record struct ListDocumentsRequestSort : IStringEnum
{
    public static readonly ListDocumentsRequestSort CreatedAt = new(Values.CreatedAt);

    public static readonly ListDocumentsRequestSort Name = new(Values.Name);

    public static readonly ListDocumentsRequestSort Size = new(Values.Size);

    public ListDocumentsRequestSort(string value)
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
    public static ListDocumentsRequestSort FromCustom(string value)
    {
        return new ListDocumentsRequestSort(value);
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

    public static bool operator ==(ListDocumentsRequestSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListDocumentsRequestSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListDocumentsRequestSort value) => value.Value;

    public static explicit operator ListDocumentsRequestSort(string value) => new(value);

    internal class ListDocumentsRequestSortSerializer : JsonConverter<ListDocumentsRequestSort>
    {
        public override ListDocumentsRequestSort Read(
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
            return new ListDocumentsRequestSort(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListDocumentsRequestSort value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListDocumentsRequestSort ReadAsPropertyName(
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
            return new ListDocumentsRequestSort(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListDocumentsRequestSort value,
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
        public const string CreatedAt = "createdAt";

        public const string Name = "name";

        public const string Size = "size";
    }
}
