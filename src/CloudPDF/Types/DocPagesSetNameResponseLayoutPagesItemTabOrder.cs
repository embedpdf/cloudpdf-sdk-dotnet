using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesSetNameResponseLayoutPagesItemTabOrder.DocPagesSetNameResponseLayoutPagesItemTabOrderSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetNameResponseLayoutPagesItemTabOrder : IStringEnum
{
    public static readonly DocPagesSetNameResponseLayoutPagesItemTabOrder Rows = new(Values.Rows);

    public static readonly DocPagesSetNameResponseLayoutPagesItemTabOrder Columns = new(
        Values.Columns
    );

    public static readonly DocPagesSetNameResponseLayoutPagesItemTabOrder Structure = new(
        Values.Structure
    );

    public static readonly DocPagesSetNameResponseLayoutPagesItemTabOrder Annotations = new(
        Values.Annotations
    );

    public static readonly DocPagesSetNameResponseLayoutPagesItemTabOrder Widgets = new(
        Values.Widgets
    );

    public DocPagesSetNameResponseLayoutPagesItemTabOrder(string value)
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
    public static DocPagesSetNameResponseLayoutPagesItemTabOrder FromCustom(string value)
    {
        return new DocPagesSetNameResponseLayoutPagesItemTabOrder(value);
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
        DocPagesSetNameResponseLayoutPagesItemTabOrder value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetNameResponseLayoutPagesItemTabOrder value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesSetNameResponseLayoutPagesItemTabOrder value) =>
        value.Value;

    public static explicit operator DocPagesSetNameResponseLayoutPagesItemTabOrder(string value) =>
        new(value);

    internal class DocPagesSetNameResponseLayoutPagesItemTabOrderSerializer
        : JsonConverter<DocPagesSetNameResponseLayoutPagesItemTabOrder>
    {
        public override DocPagesSetNameResponseLayoutPagesItemTabOrder Read(
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
            return new DocPagesSetNameResponseLayoutPagesItemTabOrder(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetNameResponseLayoutPagesItemTabOrder value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetNameResponseLayoutPagesItemTabOrder ReadAsPropertyName(
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
            return new DocPagesSetNameResponseLayoutPagesItemTabOrder(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetNameResponseLayoutPagesItemTabOrder value,
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
