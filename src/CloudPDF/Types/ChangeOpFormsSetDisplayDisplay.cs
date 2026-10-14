using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ChangeOpFormsSetDisplayDisplay.ChangeOpFormsSetDisplayDisplaySerializer))]
[Serializable]
public readonly record struct ChangeOpFormsSetDisplayDisplay : IStringEnum
{
    public static readonly ChangeOpFormsSetDisplayDisplay Visible = new(Values.Visible);

    public static readonly ChangeOpFormsSetDisplayDisplay Hidden = new(Values.Hidden);

    public static readonly ChangeOpFormsSetDisplayDisplay NoPrint = new(Values.NoPrint);

    public static readonly ChangeOpFormsSetDisplayDisplay NoView = new(Values.NoView);

    public ChangeOpFormsSetDisplayDisplay(string value)
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
    public static ChangeOpFormsSetDisplayDisplay FromCustom(string value)
    {
        return new ChangeOpFormsSetDisplayDisplay(value);
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

    public static bool operator ==(ChangeOpFormsSetDisplayDisplay value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChangeOpFormsSetDisplayDisplay value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChangeOpFormsSetDisplayDisplay value) => value.Value;

    public static explicit operator ChangeOpFormsSetDisplayDisplay(string value) => new(value);

    internal class ChangeOpFormsSetDisplayDisplaySerializer
        : JsonConverter<ChangeOpFormsSetDisplayDisplay>
    {
        public override ChangeOpFormsSetDisplayDisplay Read(
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
            return new ChangeOpFormsSetDisplayDisplay(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpFormsSetDisplayDisplay value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpFormsSetDisplayDisplay ReadAsPropertyName(
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
            return new ChangeOpFormsSetDisplayDisplay(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpFormsSetDisplayDisplay value,
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
        public const string Visible = "visible";

        public const string Hidden = "hidden";

        public const string NoPrint = "noPrint";

        public const string NoView = "noView";
    }
}
