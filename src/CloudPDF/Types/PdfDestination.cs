// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfDestination.JsonConverter))]
[Serializable]
public record PdfDestination
{
    internal PdfDestination(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.Xyz"/>.
    /// </summary>
    public PdfDestination(PdfDestination.Xyz value)
    {
        Kind = "xyz";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.Fit"/>.
    /// </summary>
    public PdfDestination(PdfDestination.Fit value)
    {
        Kind = "fit";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.FitH"/>.
    /// </summary>
    public PdfDestination(PdfDestination.FitH value)
    {
        Kind = "fitH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.FitV"/>.
    /// </summary>
    public PdfDestination(PdfDestination.FitV value)
    {
        Kind = "fitV";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.FitR"/>.
    /// </summary>
    public PdfDestination(PdfDestination.FitR value)
    {
        Kind = "fitR";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.FitB"/>.
    /// </summary>
    public PdfDestination(PdfDestination.FitB value)
    {
        Kind = "fitB";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.FitBh"/>.
    /// </summary>
    public PdfDestination(PdfDestination.FitBh value)
    {
        Kind = "fitBH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfDestination with <see cref="PdfDestination.FitBv"/>.
    /// </summary>
    public PdfDestination(PdfDestination.FitBv value)
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
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationXyz"/> if <see cref="Kind"/> is 'xyz', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'xyz'.</exception>
    public CloudPDF.PdfDestinationXyz AsXyz() =>
        IsXyz
            ? (CloudPDF.PdfDestinationXyz)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'xyz'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationFit"/> if <see cref="Kind"/> is 'fit', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fit'.</exception>
    public CloudPDF.PdfDestinationFit AsFit() =>
        IsFit
            ? (CloudPDF.PdfDestinationFit)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'fit'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationFitH"/> if <see cref="Kind"/> is 'fitH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitH'.</exception>
    public CloudPDF.PdfDestinationFitH AsFitH() =>
        IsFitH
            ? (CloudPDF.PdfDestinationFitH)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'fitH'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationFitV"/> if <see cref="Kind"/> is 'fitV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitV'.</exception>
    public CloudPDF.PdfDestinationFitV AsFitV() =>
        IsFitV
            ? (CloudPDF.PdfDestinationFitV)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'fitV'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationFitR"/> if <see cref="Kind"/> is 'fitR', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitR'.</exception>
    public CloudPDF.PdfDestinationFitR AsFitR() =>
        IsFitR
            ? (CloudPDF.PdfDestinationFitR)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'fitR'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationFitB"/> if <see cref="Kind"/> is 'fitB', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitB'.</exception>
    public CloudPDF.PdfDestinationFitB AsFitB() =>
        IsFitB
            ? (CloudPDF.PdfDestinationFitB)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'fitB'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationFitBh"/> if <see cref="Kind"/> is 'fitBH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBH'.</exception>
    public CloudPDF.PdfDestinationFitBh AsFitBh() =>
        IsFitBh
            ? (CloudPDF.PdfDestinationFitBh)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'fitBH'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfDestinationFitBv"/> if <see cref="Kind"/> is 'fitBV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBV'.</exception>
    public CloudPDF.PdfDestinationFitBv AsFitBv() =>
        IsFitBv
            ? (CloudPDF.PdfDestinationFitBv)Value!
            : throw new global::System.Exception("PdfDestination.Kind is not 'fitBV'");

    public T Match<T>(
        Func<CloudPDF.PdfDestinationXyz, T> onXyz,
        Func<CloudPDF.PdfDestinationFit, T> onFit,
        Func<CloudPDF.PdfDestinationFitH, T> onFitH,
        Func<CloudPDF.PdfDestinationFitV, T> onFitV,
        Func<CloudPDF.PdfDestinationFitR, T> onFitR,
        Func<CloudPDF.PdfDestinationFitB, T> onFitB,
        Func<CloudPDF.PdfDestinationFitBh, T> onFitBh,
        Func<CloudPDF.PdfDestinationFitBv, T> onFitBv,
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
        Action<CloudPDF.PdfDestinationXyz> onXyz,
        Action<CloudPDF.PdfDestinationFit> onFit,
        Action<CloudPDF.PdfDestinationFitH> onFitH,
        Action<CloudPDF.PdfDestinationFitV> onFitV,
        Action<CloudPDF.PdfDestinationFitR> onFitR,
        Action<CloudPDF.PdfDestinationFitB> onFitB,
        Action<CloudPDF.PdfDestinationFitBh> onFitBh,
        Action<CloudPDF.PdfDestinationFitBv> onFitBv,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationXyz"/> and returns true if successful.
    /// </summary>
    public bool TryAsXyz(out CloudPDF.PdfDestinationXyz? value)
    {
        if (Kind == "xyz")
        {
            value = (CloudPDF.PdfDestinationXyz)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationFit"/> and returns true if successful.
    /// </summary>
    public bool TryAsFit(out CloudPDF.PdfDestinationFit? value)
    {
        if (Kind == "fit")
        {
            value = (CloudPDF.PdfDestinationFit)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationFitH"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitH(out CloudPDF.PdfDestinationFitH? value)
    {
        if (Kind == "fitH")
        {
            value = (CloudPDF.PdfDestinationFitH)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationFitV"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitV(out CloudPDF.PdfDestinationFitV? value)
    {
        if (Kind == "fitV")
        {
            value = (CloudPDF.PdfDestinationFitV)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationFitR"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitR(out CloudPDF.PdfDestinationFitR? value)
    {
        if (Kind == "fitR")
        {
            value = (CloudPDF.PdfDestinationFitR)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationFitB"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitB(out CloudPDF.PdfDestinationFitB? value)
    {
        if (Kind == "fitB")
        {
            value = (CloudPDF.PdfDestinationFitB)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationFitBh"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBh(out CloudPDF.PdfDestinationFitBh? value)
    {
        if (Kind == "fitBH")
        {
            value = (CloudPDF.PdfDestinationFitBh)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfDestinationFitBv"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBv(out CloudPDF.PdfDestinationFitBv? value)
    {
        if (Kind == "fitBV")
        {
            value = (CloudPDF.PdfDestinationFitBv)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PdfDestination(PdfDestination.Xyz value) => new(value);

    public static implicit operator PdfDestination(PdfDestination.Fit value) => new(value);

    public static implicit operator PdfDestination(PdfDestination.FitH value) => new(value);

    public static implicit operator PdfDestination(PdfDestination.FitV value) => new(value);

    public static implicit operator PdfDestination(PdfDestination.FitR value) => new(value);

    public static implicit operator PdfDestination(PdfDestination.FitB value) => new(value);

    public static implicit operator PdfDestination(PdfDestination.FitBh value) => new(value);

    public static implicit operator PdfDestination(PdfDestination.FitBv value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PdfDestination>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PdfDestination).IsAssignableFrom(typeToConvert);

        public override PdfDestination Read(
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
                "xyz" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationXyz?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationXyz"),
                "fit" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationFit?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationFit"),
                "fitH" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationFitH?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationFitH"),
                "fitV" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationFitV?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationFitV"),
                "fitR" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationFitR?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationFitR"),
                "fitB" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationFitB?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationFitB"),
                "fitBH" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationFitBh?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationFitBh"),
                "fitBV" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfDestinationFitBv?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfDestinationFitBv"),
                _ => json.Deserialize<object?>(options),
            };
            return new PdfDestination(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfDestination value,
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

        public override PdfDestination ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PdfDestination(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfDestination value,
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
        public Xyz(CloudPDF.PdfDestinationXyz value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationXyz Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.Xyz(CloudPDF.PdfDestinationXyz value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fit
    /// </summary>
    [Serializable]
    public struct Fit
    {
        public Fit(CloudPDF.PdfDestinationFit value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationFit Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.Fit(CloudPDF.PdfDestinationFit value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitH
    /// </summary>
    [Serializable]
    public struct FitH
    {
        public FitH(CloudPDF.PdfDestinationFitH value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationFitH Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.FitH(CloudPDF.PdfDestinationFitH value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitV
    /// </summary>
    [Serializable]
    public struct FitV
    {
        public FitV(CloudPDF.PdfDestinationFitV value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationFitV Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.FitV(CloudPDF.PdfDestinationFitV value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitR
    /// </summary>
    [Serializable]
    public struct FitR
    {
        public FitR(CloudPDF.PdfDestinationFitR value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationFitR Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.FitR(CloudPDF.PdfDestinationFitR value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitB
    /// </summary>
    [Serializable]
    public struct FitB
    {
        public FitB(CloudPDF.PdfDestinationFitB value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationFitB Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.FitB(CloudPDF.PdfDestinationFitB value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBH
    /// </summary>
    [Serializable]
    public struct FitBh
    {
        public FitBh(CloudPDF.PdfDestinationFitBh value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationFitBh Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.FitBh(CloudPDF.PdfDestinationFitBh value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBV
    /// </summary>
    [Serializable]
    public struct FitBv
    {
        public FitBv(CloudPDF.PdfDestinationFitBv value)
        {
            Value = value;
        }

        internal CloudPDF.PdfDestinationFitBv Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfDestination.FitBv(CloudPDF.PdfDestinationFitBv value) =>
            new(value);
    }
}
