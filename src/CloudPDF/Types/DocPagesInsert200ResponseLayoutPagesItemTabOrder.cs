using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesInsert200ResponseLayoutPagesItemTabOrder.DocPagesInsert200ResponseLayoutPagesItemTabOrderSerializer)
)]
[Serializable]
public readonly record struct DocPagesInsert200ResponseLayoutPagesItemTabOrder : IStringEnum
{
    public static readonly DocPagesInsert200ResponseLayoutPagesItemTabOrder Rows = new(Values.Rows);

    public static readonly DocPagesInsert200ResponseLayoutPagesItemTabOrder Columns = new(
        Values.Columns
    );

    public static readonly DocPagesInsert200ResponseLayoutPagesItemTabOrder Structure = new(
        Values.Structure
    );

    public static readonly DocPagesInsert200ResponseLayoutPagesItemTabOrder Annotations = new(
        Values.Annotations
    );

    public static readonly DocPagesInsert200ResponseLayoutPagesItemTabOrder Widgets = new(
        Values.Widgets
    );

    public DocPagesInsert200ResponseLayoutPagesItemTabOrder(string value)
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
    public static DocPagesInsert200ResponseLayoutPagesItemTabOrder FromCustom(string value)
    {
        return new DocPagesInsert200ResponseLayoutPagesItemTabOrder(value);
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
        DocPagesInsert200ResponseLayoutPagesItemTabOrder value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesInsert200ResponseLayoutPagesItemTabOrder value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesInsert200ResponseLayoutPagesItemTabOrder value
    ) => value.Value;

    public static explicit operator DocPagesInsert200ResponseLayoutPagesItemTabOrder(
        string value
    ) => new(value);

    internal class DocPagesInsert200ResponseLayoutPagesItemTabOrderSerializer
        : JsonConverter<DocPagesInsert200ResponseLayoutPagesItemTabOrder>
    {
        public override DocPagesInsert200ResponseLayoutPagesItemTabOrder Read(
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
            return new DocPagesInsert200ResponseLayoutPagesItemTabOrder(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesInsert200ResponseLayoutPagesItemTabOrder value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesInsert200ResponseLayoutPagesItemTabOrder ReadAsPropertyName(
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
            return new DocPagesInsert200ResponseLayoutPagesItemTabOrder(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesInsert200ResponseLayoutPagesItemTabOrder value,
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
        public const string Rows = "rows";

        public const string Columns = "columns";

        public const string Structure = "structure";

        public const string Annotations = "annotations";

        public const string Widgets = "widgets";
    }
}
