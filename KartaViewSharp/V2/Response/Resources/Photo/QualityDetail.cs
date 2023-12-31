using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.Response.Resources.Photo;

[JsonSerializable(typeof(QualityDetail), GenerationMode = JsonSourceGenerationMode.Metadata)]
public sealed class QualityDetail : IEquatable<QualityDetail>
{
    [JsonPropertyName("label")]
    public int Label { get; set; }

    [JsonPropertyName("confidence")]
    public float Confidence { get; set; }

    [JsonPropertyName("presence_level")]
    public int PresenceLevel { get; set; }

    public bool Equals(QualityDetail? other)
    {
	    if (other is null)
	    {
		    return false;
	    }

	    if (ReferenceEquals(this, other))
	    {
		    return true;
	    }

	    return Label == other.Label && Confidence.Equals(other.Confidence) && PresenceLevel == other.PresenceLevel;
    }

    public override bool Equals(object? obj)
    {
	    return ReferenceEquals(this, obj) || obj is QualityDetail other && Equals(other);
    }

    public override int GetHashCode()
    {
	    return HashCode.Combine(Label, Confidence, PresenceLevel);
    }
}