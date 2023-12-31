using System.Text.Json.Serialization;
using KartaViewSharp.Common.Converters;
using KartaViewSharp.V1.Enums;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

public class User : IEquatable<User>
{
	[JsonPropertyName("id")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
	public int Id { get; set; }

	[JsonPropertyName("username")]
	public string Username { get; set; }

	[JsonPropertyName("fullName")]
	public string FullName { get; set; }

	[JsonPropertyName("category")]
	[JsonConverter(typeof(StringAsUserCategoryJsonConverter))]
	public UserCategory Category { get; set; }

	[JsonPropertyName("driverType")]
	[JsonConverter(typeof(StringAsDriverTypeJsonConverter))]
	public DriverType DriverType { get; set; }

	public bool Equals(User? other)
	{
		if (other is null)
		{
			return false;
		}

		if (ReferenceEquals(this, other))
		{
			return true;
		}

		return Id == other.Id && Username == other.Username && FullName == other.FullName && Category == other.Category && DriverType == other.DriverType;
	}

	public override bool Equals(object? obj)
	{
		if (obj is null)
		{
			return false;
		}

		if (ReferenceEquals(this, obj))
		{
			return true;
		}

		if (obj.GetType() != this.GetType())
		{
			return false;
		}

		return Equals((User)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Id, Username, FullName, (int)Category, (int)DriverType);
	}
}