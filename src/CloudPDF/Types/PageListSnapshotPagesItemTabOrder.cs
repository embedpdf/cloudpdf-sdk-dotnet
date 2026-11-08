using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PageListSnapshotPagesItemTabOrder.PageListSnapshotPagesItemTabOrderSerializer)
)]
[Serializable]
public readonly record struct PageListSnapshotPagesItemTabOrder : IStringEnum
{
    public static readonly PageListSnapshotPagesItemTabOrder Rows = new(Values.Rows);

    public static readonly PageListSnapshotPagesItemTabOrder Columns = new(Values.Columns);

    public static readonly PageListSnapshotPagesItemTabOrder Structure = new(Values.Structure);

    public static readonly PageListSnapshotPagesItemTabOrder Annotations = new(Values.Annotations);

    public static readonly PageListSnapshotPagesItemTabOrder Widgets = new(Values.Widgets);

    public PageListSnapshotPagesItemTabOrder(string value)
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
    public static PageListSnapshotPagesItemTabOrder FromCustom(string value)
    {
        return new PageListSnapshotPagesItemTabOrder(value);
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

    public static bool operator ==(PageListSnapshotPagesItemTabOrder value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PageListSnapshotPagesItemTabOrder value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PageListSnapshotPagesItemTabOrder value) => value.Value;

    public static explicit operator PageListSnapshotPagesItemTabOrder(string value) => new(value);

    internal class PageListSnapshotPagesItemTabOrderSerializer
        : JsonConverter<PageListSnapshotPagesItemTabOrder>
    {
        public override PageListSnapshotPagesItemTabOrder Read(
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
            return new PageListSnapshotPagesItemTabOrder(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PageListSnapshotPagesItemTabOrder value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PageListSnapshotPagesItemTabOrder ReadAsPropertyName(
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
            return new PageListSnapshotPagesItemTabOrder(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PageListSnapshotPagesItemTabOrder value,
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
