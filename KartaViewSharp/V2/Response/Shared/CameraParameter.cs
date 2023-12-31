using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.Response.Shared;

[JsonSerializable(typeof(CameraParameter), GenerationMode = JsonSourceGenerationMode.Metadata)]
public class CameraParameter : IEquatable<CameraParameter>
{
    /// <summary>
    /// Precentage where f is the focal length, and D is the diameter of the entrance pupil.
    /// </summary>
    [JsonPropertyName("fNumber")]
    public double? FNumber { get; set; }

    /// <summary>
    /// The focal length of an optical system that measures how strongly the system converges or diverges light.
    /// </summary>
    [JsonPropertyName("fLen")]
    public double? FLen { get; set; }

    /// <summary>
    /// Field of view in degrees. If field of view is unknown, a value of 0 is returned.
    /// </summary>
    [JsonPropertyName("vFoV")]
    public double? VFov { get; set; }

    /// <summary>
    /// Field of view in degrees. If field of view is unknown, a value of 0 is returned.
    /// </summary>
    [JsonPropertyName("hFoV")]
    public double? HFov { get; set; }

    /// <summary>
    /// A value that controls the cropping and enlargement of images captured by the device. For example, a value of 2.0 doubles the size of an image’s subject (and halves the field of view).
    /// </summary>
    [JsonPropertyName("vZF")]
    public double? VZf { get; set; }

    /// <summary>
    /// Aperture of the device, an opening through which light travels. The aperture and focal length of an optical system determine the cone angle of a bundle of rays that come to a focus in the image plane.
    /// </summary>
    [JsonPropertyName("aperture")]
    public double? Aperture { get; set; }

	[JsonPropertyName("width")]
	public int? Width { get; set; }

	[JsonPropertyName("height")]
	public int? Height { get; set; }

	public bool Equals(CameraParameter? other)
	{
		if (other is null) return false;
		if (ReferenceEquals(this, other)) return true;
		return Nullable.Equals(FNumber, other.FNumber) &&
		       Nullable.Equals(FLen, other.FLen) &&
		       Nullable.Equals(VFov, other.VFov) &&
		       Nullable.Equals(HFov, other.HFov) &&
		       Nullable.Equals(VZf, other.VZf) &&
		       Nullable.Equals(Aperture, other.Aperture) &&
		       Width == other.Width &&
		       Height == other.Height;
	}

	public override bool Equals(object? obj)
	{
		if (obj is null) return false;
		if (ReferenceEquals(this, obj)) return true;
		if (obj.GetType() != this.GetType()) return false;
		return Equals((CameraParameter)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(FNumber, FLen, VFov, HFov, VZf, Aperture, Width, Height);
	}
}