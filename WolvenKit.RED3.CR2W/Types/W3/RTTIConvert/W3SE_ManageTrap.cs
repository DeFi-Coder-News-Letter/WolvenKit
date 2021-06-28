using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_ManageTrap : W3SwitchEvent
	{
		[Ordinal(1)] [RED("trapHandle", 2,0)] 		public CArray<EntityHandle> TrapHandle { get; set;}

		[Ordinal(2)] [RED("trapTag")] 		public CName TrapTag { get; set;}

		[Ordinal(3)] [RED("operations", 2,0)] 		public CArray<CEnum<ETrapOperation>> Operations { get; set;}

		public W3SE_ManageTrap(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}