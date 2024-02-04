using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using _28AL.CC.Blocks;

namespace _28AL.CC;

public static class TEAdaptation
{
	[HarmonyPatch(typeof(TileEntityGoreBlock), "UpdateTick")]
	static class Patches__TileEntityGoreBlock__UpdateTick
	{
		static IEnumerable<CodeInstruction> Transpiler()
		{
			yield return new CodeInstruction(OpCodes.Ldarg_0);
			yield return new CodeInstruction(OpCodes.Ldarg_1);
			yield return new CodeInstruction(OpCodes.Call,
				AccessTools.Method("TileEntityLootContainer:UpdateTick"));
			yield return new CodeInstruction(OpCodes.Ret);
		}
	}

	[HarmonyPatch(typeof(TileEntity), "IsActive")]
	static class Patches__TileEntity__IsActive
	{
		static bool Prefix(TileEntity __instance, ref bool __result)
		{
			if(__instance is TileEntityGoreBlock){
				__result = true;
				return false;
			}

			if(__instance is TileEntityLight){
				if (__instance.blockValue.Block is BlockLightAlwaysOnTE) {
					__result = true;
					return false;
				}
				
				__result = (__instance.blockValue.meta & 2) > 0;
				return false;
			}

			return true;
		}
	}

	[HarmonyPatch(typeof(EntityPlayerLocal), "updateBlockRadiusEffects")]
	static class Patches__EntityPlayerLocal__updateBlockRadiusEffects
	{
		static IEnumerable<CodeInstruction> Transpiler(
				IEnumerable<CodeInstruction> instructions)
		{
			CodeMatcher cm = new(instructions);

			cm.Start().
				SearchForward(a => a.operand is MethodInfo { Name: "HasBuff" }).
				SearchBackwards(a => a.opcode == OpCodes.Ldarg_0).
				RemoveInstructions(6);
			
			return cm.InstructionEnumeration();
		}
	}
}