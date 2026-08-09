// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.JsonConverter)
)]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination
{
    internal DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        string type,
        object? value
    )
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Xyz"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Xyz value
    )
    {
        Kind = "xyz";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Fit"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Fit value
    )
    {
        Kind = "fit";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitH"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitH value
    )
    {
        Kind = "fitH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitV"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitV value
    )
    {
        Kind = "fitV";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitR"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitR value
    )
    {
        Kind = "fitR";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitB"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitB value
    )
    {
        Kind = "fitB";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBh"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBh value
    )
    {
        Kind = "fitBH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBv"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBv value
    )
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz"/> if <see cref="Kind"/> is 'xyz', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'xyz'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz AsXyz() =>
        IsXyz
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'xyz'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit"/> if <see cref="Kind"/> is 'fit', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fit'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit AsFit() =>
        IsFit
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'fit'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH"/> if <see cref="Kind"/> is 'fitH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitH'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH AsFitH() =>
        IsFitH
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitH'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV"/> if <see cref="Kind"/> is 'fitV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitV'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV AsFitV() =>
        IsFitV
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitV'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR"/> if <see cref="Kind"/> is 'fitR', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitR'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR AsFitR() =>
        IsFitR
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitR'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB"/> if <see cref="Kind"/> is 'fitB', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitB'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB AsFitB() =>
        IsFitB
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitB'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh"/> if <see cref="Kind"/> is 'fitBH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBH'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh AsFitBh() =>
        IsFitBh
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitBH'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv"/> if <see cref="Kind"/> is 'fitBV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBV'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv AsFitBv() =>
        IsFitBv
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitBV'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz,
            T
        > onXyz,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit,
            T
        > onFit,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH,
            T
        > onFitH,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV,
            T
        > onFitV,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR,
            T
        > onFitR,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB,
            T
        > onFitB,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh,
            T
        > onFitBh,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv,
            T
        > onFitBv,
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
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz> onXyz,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit> onFit,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH> onFitH,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV> onFitV,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR> onFitR,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB> onFitB,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh> onFitBh,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv> onFitBv,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz"/> and returns true if successful.
    /// </summary>
    public bool TryAsXyz(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz? value
    )
    {
        if (Kind == "xyz")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit"/> and returns true if successful.
    /// </summary>
    public bool TryAsFit(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit? value
    )
    {
        if (Kind == "fit")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitH(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH? value
    )
    {
        if (Kind == "fitH")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitV(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV? value
    )
    {
        if (Kind == "fitV")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitR(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR? value
    )
    {
        if (Kind == "fitR")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitB(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB? value
    )
    {
        if (Kind == "fitB")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBh(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh? value
    )
    {
        if (Kind == "fitBH")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBv(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv? value
    )
    {
        if (Kind == "fitBV")
        {
            value =
                (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Xyz value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Fit value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitH value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitV value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitR value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitB value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBh value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBv value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination Read(
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
                "xyz" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz"
                        ),
                "fit" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit"
                        ),
                "fitH" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH"
                        ),
                "fitV" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV"
                        ),
                "fitR" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR"
                        ),
                "fitB" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB"
                        ),
                "fitBH" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh"
                        ),
                "fitBV" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination value,
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

        public override DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination value,
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
        public Xyz(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Xyz(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationXyz value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fit
    /// </summary>
    [Serializable]
    public struct Fit
    {
        public Fit(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.Fit(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFit value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitH
    /// </summary>
    [Serializable]
    public struct FitH
    {
        public FitH(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitH(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitH value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitV
    /// </summary>
    [Serializable]
    public struct FitV
    {
        public FitV(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitV(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitV value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitR
    /// </summary>
    [Serializable]
    public struct FitR
    {
        public FitR(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitR(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitR value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitB
    /// </summary>
    [Serializable]
    public struct FitB
    {
        public FitB(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitB(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitB value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBH
    /// </summary>
    [Serializable]
    public struct FitBh
    {
        public FitBh(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBh(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBh value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBV
    /// </summary>
    [Serializable]
    public struct FitBv
    {
        public FitBv(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestination.FitBv(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoDestinationFitBv value
        ) => new(value);
    }
}
