using static HarmonyLib.Tools.Logger;

public class Init : IModApi
{
	public static Mod? ModInstance { get; private set; }
	public static Harmony? HarmonyInstance { get; private set; }

	public void InitMod(Mod _modInstance)
	{
		ModInstance = _modInstance;
    string version = _modInstance.VersionString.Replace('.', '-');
    HarmonyInstance = new(_modInstance.Name + "." + version);
		ConfigureLogging();
		HarmonyInstance.PatchAll(typeof(Init).Assembly);
	}

	public static void ConfigureLogging(
			bool verbose = false,
			bool includeIL = false)
	{
		ChannelFilter = LogChannel.None | LogChannel.Warn | LogChannel.Error | LogChannel.Info;

#if DEBUG
    if(includeIL){
      ChannelFilter |= LogChannel.IL;
    }

		ChannelFilter |= LogChannel.Debug;
#endif
	}
}