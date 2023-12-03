using System.Xml.Linq;

namespace _28AL.ParticleSystems;

public class Detach : MinEventActionTargetedBase
{
	public override void Execute(MinEventParams _params)
	{
		EntityAlive? target = null;

		if(targetType == TargetTypes.self){
			target = _params.Self;
		} else if(targetType == TargetTypes.other){
			target = _params.Other;
		}

		if(target is null){
			return;
		}

		if(SingletonMonoBehaviour<ConnectionManager>.Instance.IsServer){
			SingletonMonoBehaviour<ConnectionManager>.Instance.SendPackage(
				NetPackageManager.GetPackage<NetPackageAddRemoveBuffParticles>().
					SetupRemove(target.entityId, peName),
						false, -1, target.entityId, -1, -1);
			return;
		}

		SingletonMonoBehaviour<ConnectionManager>.Instance.SendToServer(
			NetPackageManager.GetPackage<NetPackageAddRemoveBuffParticles>().
				SetupRemove(target.entityId, peName), false);
	}

	public override bool CanExecute(
			MinEventTypes _eventType,
			MinEventParams _params) =>
		base.CanExecute(_eventType, _params)
			&& peName != null;

	public override bool ParseXmlAttribute(XAttribute _attribute)
	{
		if (_attribute.Name.LocalName == "particle"){
			peName = _attribute.Value;
			return true;
		}

		return base.ParseXmlAttribute(_attribute);
	}

	string? peName;
}
