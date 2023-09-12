using UnityEngine;
using UnityEngine.SceneManagement;

namespace LatencyFix
{
	public class LatencyBehaviour : ModBehaviour
	{
		bool _isActive = false;
		bool _onMain = true;

		public override void OnActivate()
		{
			_isActive = _onMain;

			SceneManager.sceneLoaded += SceneManager_sceneLoaded;
		}

		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
			_onMain = scene.name == "MainMenu";
		}

		public override void OnDeactivate()
		{
			_isActive = false;
		}

		public void Update()
		{
			if (_isActive && _onMain)
			{
				GameObject go = GameObject.Find("NetworkWindow/ContentPanel/MainPanel/SteamFilter/Latency");
				if (go != null)
				{
					//Could find the button
					GUICombobox dropdown = go.GetComponent<GUICombobox>();
					if(dropdown.Items.Count == 4) {
						return;
					}
					dropdown.UpdateContent(new string[4] { "Low", "Default", "High", "Worldwide" });
				}
			}
		}

	}
}
