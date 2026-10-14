// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PageDestination.JsonConverter))]
[Serializable]
public record PageDestination
{
    internal PageDestination(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.Xyz"/>.
    /// </summary>
    public PageDestination(PageDestination.Xyz value)
    {
        Kind = "xyz";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.Fit"/>.
    /// </summary>
    public PageDestination(PageDestination.Fit value)
    {
        Kind = "fit";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.FitH"/>.
    /// </summary>
    public PageDestination(PageDestination.FitH value)
    {
        Kind = "fitH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.FitV"/>.
    /// </summary>
    public PageDestination(PageDestination.FitV value)
    {
        Kind = "fitV";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.FitR"/>.
    /// </summary>
    public PageDestination(PageDestination.FitR value)
    {
        Kind = "fitR";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.FitB"/>.
    /// </summary>
    public PageDestination(PageDestination.FitB value)
    {
        Kind = "fitB";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.FitBh"/>.
    /// </summary>
    public PageDestination(PageDestination.FitBh value)
    {
        Kind = "fitBH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageDestination with <see cref="PageDestination.FitBv"/>.
    /// </summary>
    public PageDestination(PageDestination.FitBv value)
    {
        Kind = "fitBV";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "xyz"
    /// </summary>
    public bool IsXyz => Kind == "xyz";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fit"
    /// </summary>
    public bool IsFit => Kind == "fit";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitH"
    /// </summary>
    public bool IsFitH => Kind == "fitH";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitV"
    /// </summary>
    public bool IsFitV => Kind == "fitV";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitR"
    /// </summary>
    public bool IsFitR => Kind == "fitR";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitB"
    /// </summary>
    public bool IsFitB => Kind == "fitB";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitBH"
    /// </summary>
    public bool IsFitBh => Kind == "fitBH";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitBV"
    /// </summary>
    public bool IsFitBv => Kind == "fitBV";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationXyz"/> if <see cref="Kind"/> is 'xyz', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'xyz'.</exception>
    public CloudPDF.PageDestinationXyz AsXyz() =>
        IsXyz
            ? (CloudPDF.PageDestinationXyz)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'xyz'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationFit"/> if <see cref="Kind"/> is 'fit', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fit'.</exception>
    public CloudPDF.PageDestinationFit AsFit() =>
        IsFit
            ? (CloudPDF.PageDestinationFit)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'fit'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationFitH"/> if <see cref="Kind"/> is 'fitH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitH'.</exception>
    public CloudPDF.PageDestinationFitH AsFitH() =>
        IsFitH
            ? (CloudPDF.PageDestinationFitH)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'fitH'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationFitV"/> if <see cref="Kind"/> is 'fitV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitV'.</exception>
    public CloudPDF.PageDestinationFitV AsFitV() =>
        IsFitV
            ? (CloudPDF.PageDestinationFitV)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'fitV'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationFitR"/> if <see cref="Kind"/> is 'fitR', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitR'.</exception>
    public CloudPDF.PageDestinationFitR AsFitR() =>
        IsFitR
            ? (CloudPDF.PageDestinationFitR)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'fitR'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationFitB"/> if <see cref="Kind"/> is 'fitB', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitB'.</exception>
    public CloudPDF.PageDestinationFitB AsFitB() =>
        IsFitB
            ? (CloudPDF.PageDestinationFitB)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'fitB'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationFitBh"/> if <see cref="Kind"/> is 'fitBH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBH'.</exception>
    public CloudPDF.PageDestinationFitBh AsFitBh() =>
        IsFitBh
            ? (CloudPDF.PageDestinationFitBh)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'fitBH'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageDestinationFitBv"/> if <see cref="Kind"/> is 'fitBV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBV'.</exception>
    public CloudPDF.PageDestinationFitBv AsFitBv() =>
        IsFitBv
            ? (CloudPDF.PageDestinationFitBv)Value!
            : throw new global::System.Exception("PageDestination.Kind is not 'fitBV'");

    public T Match<T>(
        Func<CloudPDF.PageDestinationXyz, T> onXyz,
        Func<CloudPDF.PageDestinationFit, T> onFit,
        Func<CloudPDF.PageDestinationFitH, T> onFitH,
        Func<CloudPDF.PageDestinationFitV, T> onFitV,
        Func<CloudPDF.PageDestinationFitR, T> onFitR,
        Func<CloudPDF.PageDestinationFitB, T> onFitB,
        Func<CloudPDF.PageDestinationFitBh, T> onFitBh,
        Func<CloudPDF.PageDestinationFitBv, T> onFitBv,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "xyz" => onXyz(AsXyz()),
            "fit" => onFit(AsFit()),
            "fitH" => onFitH(AsFitH()),
            "fitV" => onFitV(AsFitV()),
            "fitR" => onFitR(AsFitR()),
            "fitB" => onFitB(AsFitB()),
            "fitBH" => onFitBh(AsFitBh()),
            "fitBV" => onFitBv(AsFitBv()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.PageDestinationXyz> onXyz,
        Action<CloudPDF.PageDestinationFit> onFit,
        Action<CloudPDF.PageDestinationFitH> onFitH,
        Action<CloudPDF.PageDestinationFitV> onFitV,
        Action<CloudPDF.PageDestinationFitR> onFitR,
        Action<CloudPDF.PageDestinationFitB> onFitB,
        Action<CloudPDF.PageDestinationFitBh> onFitBh,
        Action<CloudPDF.PageDestinationFitBv> onFitBv,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "xyz":
                onXyz(AsXyz());
                break;
            case "fit":
                onFit(AsFit());
                break;
            case "fitH":
                onFitH(AsFitH());
                break;
            case "fitV":
                onFitV(AsFitV());
                break;
            case "fitR":
                onFitR(AsFitR());
                break;
            case "fitB":
                onFitB(AsFitB());
                break;
            case "fitBH":
                onFitBh(AsFitBh());
                break;
            case "fitBV":
                onFitBv(AsFitBv());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationXyz"/> and returns true if successful.
    /// </summary>
    public bool TryAsXyz(out CloudPDF.PageDestinationXyz? value)
    {
        if (Kind == "xyz")
        {
            value = (CloudPDF.PageDestinationXyz)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationFit"/> and returns true if successful.
    /// </summary>
    public bool TryAsFit(out CloudPDF.PageDestinationFit? value)
    {
        if (Kind == "fit")
        {
            value = (CloudPDF.PageDestinationFit)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationFitH"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitH(out CloudPDF.PageDestinationFitH? value)
    {
        if (Kind == "fitH")
        {
            value = (CloudPDF.PageDestinationFitH)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationFitV"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitV(out CloudPDF.PageDestinationFitV? value)
    {
        if (Kind == "fitV")
        {
            value = (CloudPDF.PageDestinationFitV)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationFitR"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitR(out CloudPDF.PageDestinationFitR? value)
    {
        if (Kind == "fitR")
        {
            value = (CloudPDF.PageDestinationFitR)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationFitB"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitB(out CloudPDF.PageDestinationFitB? value)
    {
        if (Kind == "fitB")
        {
            value = (CloudPDF.PageDestinationFitB)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationFitBh"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBh(out CloudPDF.PageDestinationFitBh? value)
    {
        if (Kind == "fitBH")
        {
            value = (CloudPDF.PageDestinationFitBh)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageDestinationFitBv"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBv(out CloudPDF.PageDestinationFitBv? value)
    {
        if (Kind == "fitBV")
        {
            value = (CloudPDF.PageDestinationFitBv)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PageDestination(PageDestination.Xyz value) => new(value);

    public static implicit operator PageDestination(PageDestination.Fit value) => new(value);

    public static implicit operator PageDestination(PageDestination.FitH value) => new(value);

    public static implicit operator PageDestination(PageDestination.FitV value) => new(value);

    public static implicit operator PageDestination(PageDestination.FitR value) => new(value);

    public static implicit operator PageDestination(PageDestination.FitB value) => new(value);

    public static implicit operator PageDestination(PageDestination.FitBh value) => new(value);

    public static implicit operator PageDestination(PageDestination.FitBv value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PageDestination>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PageDestination).IsAssignableFrom(typeToConvert);

        public override PageDestination Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("kind", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'kind'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'kind' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'kind' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'kind' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("kind");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "xyz" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationXyz?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationXyz"),
                "fit" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationFit?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationFit"),
                "fitH" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationFitH?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationFitH"),
                "fitV" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationFitV?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationFitV"),
                "fitR" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationFitR?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationFitR"),
                "fitB" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationFitB?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationFitB"),
                "fitBH" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationFitBh?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationFitBh"),
                "fitBV" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PageDestinationFitBv?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PageDestinationFitBv"),
                _ => json.Deserialize<object?>(options),
            };
            return new PageDestination(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PageDestination value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "xyz" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fit" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitH" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitV" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitR" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitB" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitBH" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitBV" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override PageDestination ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PageDestination(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PageDestination value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for xyz
    /// </summary>
    [Serializable]
    public struct Xyz
    {
        public Xyz(CloudPDF.PageDestinationXyz value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationXyz Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.Xyz(CloudPDF.PageDestinationXyz value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fit
    /// </summary>
    [Serializable]
    public struct Fit
    {
        public Fit(CloudPDF.PageDestinationFit value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationFit Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.Fit(CloudPDF.PageDestinationFit value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitH
    /// </summary>
    [Serializable]
    public struct FitH
    {
        public FitH(CloudPDF.PageDestinationFitH value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationFitH Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.FitH(CloudPDF.PageDestinationFitH value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitV
    /// </summary>
    [Serializable]
    public struct FitV
    {
        public FitV(CloudPDF.PageDestinationFitV value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationFitV Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.FitV(CloudPDF.PageDestinationFitV value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitR
    /// </summary>
    [Serializable]
    public struct FitR
    {
        public FitR(CloudPDF.PageDestinationFitR value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationFitR Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.FitR(CloudPDF.PageDestinationFitR value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitB
    /// </summary>
    [Serializable]
    public struct FitB
    {
        public FitB(CloudPDF.PageDestinationFitB value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationFitB Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.FitB(CloudPDF.PageDestinationFitB value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBH
    /// </summary>
    [Serializable]
    public struct FitBh
    {
        public FitBh(CloudPDF.PageDestinationFitBh value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationFitBh Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.FitBh(
            CloudPDF.PageDestinationFitBh value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBV
    /// </summary>
    [Serializable]
    public struct FitBv
    {
        public FitBv(CloudPDF.PageDestinationFitBv value)
        {
            Value = value;
        }

        internal CloudPDF.PageDestinationFitBv Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageDestination.FitBv(
            CloudPDF.PageDestinationFitBv value
        ) => new(value);
    }
}
