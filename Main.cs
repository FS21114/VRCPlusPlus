using MelonLoader;
using VRC.SDKBase;

namespace VRCPlusPlus
{
	class Main : MelonMod
	{
		string username;
		bool reset;
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if (sceneName != "loader" && sceneName != "Application2" && sceneName != "ui")
			{
				reset = true;
			}
			else
			{
				username = null;
			}
		}
		public override void OnLateUpdate()
		{
			if (reset && RoomManager.field_Internal_Static_ApiWorld_0.authorName != null)
			{
				reset = false;
				username = RoomManager.field_Internal_Static_ApiWorld_0.authorName;
			}
			if (username != null)
			{
				Networking.LocalPlayer.displayName = username;
			}
		}
	}
}