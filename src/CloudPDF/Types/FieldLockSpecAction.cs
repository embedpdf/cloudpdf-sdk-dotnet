using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FieldLockSpecAction.FieldLockSpecActionSerializer))]
[Serializable]
public readonly record struct FieldLockSpecAction : IStringEnum
{
    public static readonly FieldLockSpecAction All = new(Values.All);

    public static readonly FieldLockSpecAction Include = new(Values.Include);

    public static readonly FieldLockSpecAction Exclude = new(Values.Exclude);

    public FieldLockSpecAction(string value)
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
    public static FieldLockSpecAction FromCustom(string value)
    {
        return new FieldLockSpecAction(value);
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

    public static bool operator ==(FieldLockSpecAction value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldLockSpecAction value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldLockSpecAction value) => value.Value;

    public static explicit operator FieldLockSpecAction(string value) => new(value);

    internal class FieldLockSpecActionSerializer : JsonConverter<FieldLockSpecAction>
    {
        public override FieldLockSpecAction Read(
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
            return new FieldLockSpecAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FieldLockSpecAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FieldLockSpecAction ReadAsPropertyName(
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
            return new FieldLockSpecAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FieldLockSpecAction value,
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
        public const string All = "all";

        public const string Include = "include";

        public const string Exclude = "exclude";
    }
}
