using UnityEditorLayoutWrapper.Layout.Style;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class Foldout {
		public static bool Custom(bool value, string label = "") {
			return GUILayout.Toggle(
				value,
				label,
				UnityEditorLayoutStyle.Skin.toggle,
				GUILayout.MaxWidth(10),
				GUILayout.MaxHeight(10));
		}
	}
}