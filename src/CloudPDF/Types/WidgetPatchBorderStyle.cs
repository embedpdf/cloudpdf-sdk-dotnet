using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPatchBorderStyle.WidgetPatchBorderStyleSerializer))]
[Serializable]
public readonly record struct WidgetPatchBorderStyle : IStringEnum
{
    public static readonly WidgetPatchBorderStyle Solid = new(Values.Solid);

    public static readonly WidgetPatchBorderStyle Dashed = new(Values.Dashed);

    public static readonly WidgetPatchBorderStyle Beveled = new(Values.Beveled);

    public static readonly WidgetPatchBorderStyle Inset = new(Values.Inset);

    public static readonly WidgetPatchBorderStyle Underline = new(Values.Underline);

    public WidgetPatchBorderStyle(string value)
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
    public static WidgetPatchBorderStyle FromCustom(string value)
    {
        return new WidgetPatchBorderStyle(value);
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

    public static bool operator ==(WidgetPatchBorderStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPatchBorderStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPatchBorderStyle value) => value.Value;

    public static explicit operator WidgetPatchBorderStyle(string value) => new(value);

    internal class WidgetPatchBorderStyleSerializer : JsonConverter<WidgetPatchBorderStyle>
    {
        public override WidgetPatchBorderStyle Read(
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
            return new WidgetPatchBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPatchBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPatchBorderStyle ReadAsPropertyName(
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
            return new WidgetPatchBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPatchBorderStyle value,
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
        public const string Solid = "solid";

        public const string Dashed = "dashed";

        public const string Beveled = "beveled";

        public const string Inset = "inset";

        public const string Underline = "underline";
    }
}
