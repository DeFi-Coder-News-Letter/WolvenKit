
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAbsoluteZLimiterCoverSelectionParameters_Record
	{
		[RED("scoreOnlyForCombatTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool ScoreOnlyForCombatTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("vaidateOnlyForCombatTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool VaidateOnlyForCombatTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("zLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
