using System;
using UnityEditorLayoutWrapper.Layout.Style;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class Scroll {
		public static void HorizontalAndVertical(ref Vector2 scroll, Action block) {
			scroll = GUILayout.BeginScrollView(scroll, false, false,
				UnityEditorLayoutStyle.Skin.horizontalScrollbar,
				UnityEditorLayoutStyle.Skin.verticalScrollbar);
			block();
			GUILayout.EndScrollView();
		}

		public static void Vertical(ref Vector2 scroll, Action block) {
			scroll = GUILayout.BeginScrollView(scroll, false, false, GUIStyle.none,
				UnityEditorLayoutStyle.Skin.verticalScrollbar);
			block();
			GUILayout.EndScrollView();
		}

		public static void Horizontal(ref Vector2 scroll, Action block) {
			scroll = GUILayout.BeginScrollView(scroll, false, false,
				UnityEditorLayoutStyle.Skin.horizontalScrollbar, GUIStyle.none);
			block();
			GUILayout.EndScrollView();
		}
	}
}