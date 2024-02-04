using System.Xml.Linq;

namespace _28AL.CC.MinEventActions;

public class MinEventActionGetLightLevel : MinEventActionTargetedBase
{
	private string cvar = "";

	public override void Execute(MinEventParams _params)
	{
		foreach(Entity target in targets){
			if(target is not EntityAlive ea){
				continue;
			}

			ea.SetCVar(cvar, Mathf.Clamp01(
				LightManager.GetStealthLightLevel(ea, out var _) + ea.GetLightLevel()));
		}

		base.Execute(_params);
	}

	public override bool ParseXmlAttribute(XAttribute _attribute)
	{
		if(_attribute.Name == "receiving_cvar"){
			cvar = _attribute.Value;
			return true;
		}

		return base.ParseXmlAttribute(_attribute);
	}
}