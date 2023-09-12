using UnityEngine;
using UnityEngine.UI;

namespace LatencyFix
{
	public class MyModMeta : ModMeta
	{

		public override string Name => "Wordwide Multiplayer";

		public override void ConstructOptionsScreen(RectTransform parent, bool inGame)
		{
			Text text = WindowManager.SpawnLabel();
			text.text = "Play the game with your friends from all around the world!\nIt could negatively influence your experience with the game due to high latency!";
			WindowManager.AddElementToElement(text.gameObject, parent.gameObject, new Rect(0f, 0f, 400f, 128f),
				new Rect(0f, 0f, 0f, 0f));
		}
	}
}
