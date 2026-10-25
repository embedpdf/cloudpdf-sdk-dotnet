using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesRotateLayoutPagesItemTabOrder.ChangeItemPagesRotateLayoutPagesItemTabOrderSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesRotateLayoutPagesItemTabOrder : IStringEnum
{
    public static readonly ChangeItemPagesRotateLayoutPagesItemTabOrder Rows = new(Values.Rows);

    public static readonly ChangeItemPagesRotateLayoutPagesItemTabOrder Columns = new(
        Values.Columns
    );

    public static readonly ChangeItemPagesRotateLayoutPagesItemTabOrder Structure = new(
        Values.Structure
    );

    public static readonly ChangeItemPagesRotateLayoutPagesItemTabOrder Annotations = new(
        Values.Annotations
    );

    public static readonly ChangeItemPagesRotateLayoutPagesItemTabOrder Widgets = new(
        Values.Widgets
    );

    public ChangeItemPagesRotateLayoutPagesItemTabOrder(string value)
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
    public static ChangeItemPagesRotateLayoutPagesItemTabOrder FromCustom(string value)
    {
        return new ChangeItemPagesRotateLayoutPagesItemTabOrder(value);
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
        ChangeItemPagesRotateLayoutPagesItemTabOrder value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesRotateLayoutPagesItemTabOrder value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesRotateLayoutPagesItemTabOrder value) =>
        value.Value;

    public static explicit operator ChangeItemPagesRotateLayoutPagesItemTabOrder(string value) =>
        new(value);

    internal class ChangeItemPagesRotateLayoutPagesItemTabOrderSerializer
        : JsonConverter<ChangeItemPagesRotateLayoutPagesItemTabOrder>
    {
        public override ChangeItemPagesRotateLayoutPagesItemTabOrder Read(
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
            return new ChangeItemPagesRotateLayoutPagesItemTabOrder(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesRotateLayoutPagesItemTabOrder value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesRotateLayoutPagesItemTabOrder ReadAsPropertyName(
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
            return new ChangeItemPagesRotateLayoutPagesItemTabOrder(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesRotateLayoutPagesItemTabOrder value,
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
