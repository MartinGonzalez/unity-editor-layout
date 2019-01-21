using UnityEditor;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class Background {
		public static void ForWindow(Color color) {
			EditorGUI.DrawRect(new Rect(0, 0, Screen.width, Screen.height), color);
		}
	}
}