using MelonLoader;
using VRC.SDKBase;

namespace VRCPlusPlus
{
	class Main : MelonMod
	{
		string username;
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if (sceneName != "loader" && sceneName != "Application2" && sceneName != "ui")
			{
				if (sceneName == "Main")
				{
					username = "LoliGoddess";
				}
				else if (sceneName == "PrisonEscape")
				{
					username = "Ostinyo";
				}
				else if (sceneName == "Skeld")
				{
					username = "Jar";
				}
				else
				{
					username = null;
				}
			}
			else
			{
				username = null;
			}
		}
		public override void OnLateUpdate()
		{
			if (username != null)
			{
				Networking.LocalPlayer.displayName = username;
			}
		}
	}
}