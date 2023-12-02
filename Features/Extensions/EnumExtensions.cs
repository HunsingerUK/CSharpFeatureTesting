using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection;

namespace Features.Extensions;

public static class EnumExtensions
{
	public static T GetAttributeOfType<T>(this Enum enumVal) where T : System.Attribute
	{
		Type type = enumVal.GetType();
		MemberInfo[] memInfo = type.GetMember(enumVal.ToString());
		object[] attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
		return (attributes.Length > 0) ? (T)attributes[0] : null;
	}

	public static string GetDescription(this Enum enumValue)
	{
		Type type = enumValue.GetType();
		MemberInfo[] memInfo = type.GetMember(enumValue.ToString());
		DescriptionAttribute? descriptionAttribute = memInfo.First().GetCustomAttribute<DescriptionAttribute>();

		return descriptionAttribute != null ? descriptionAttribute.Description : enumValue.ToString();
	}

	public static string GetDisplay(this Enum enumValue)
	{
		Type type = enumValue.GetType();
		MemberInfo[] memInfo = type.GetMember(enumValue.ToString());
		DisplayAttribute? displayAttribute = memInfo.First().GetCustomAttribute<DisplayAttribute>();

		return displayAttribute != null ? displayAttribute.Name : enumValue.ToString();
	}

	public static IList<T> GetValues<T>()
	{
		return Enum.GetValues(typeof(T)).OfType<T>().ToList();
	}
}
