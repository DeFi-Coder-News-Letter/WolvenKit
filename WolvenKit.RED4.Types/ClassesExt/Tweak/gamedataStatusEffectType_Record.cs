
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectType_Record
	{
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CString EnumName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
