using System;
using UnityEditor;
using UnityEditorLayoutWrapper.Layout;
using UnityEditorLayoutWrapper.Layout.Style;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class Layout {
		public static void Horizontal(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginHorizontal(options);
			block();
			GUILayout.EndHorizontal();
		}

		public static void HorizontalHelpbox(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginHorizontal(EditorStyles.helpBox, options);
			block();
			GUILayout.EndHorizontal();
		}

		public static void HorizontalBox(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginHorizontal(UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.BoxSub));
			block();
			GUILayout.EndHorizontal();
		}

		public static void HorizontalWhiteBox(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginHorizontal(UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.WhiteBox), options);
			block();
			GUILayout.EndHorizontal();
		}

		public static void HorizontallyCentered(Action block) {
			Horizontal(() => {
				GUILayout.FlexibleSpace();
				block();
				GUILayout.FlexibleSpace();
			});
		}

		public static void Vertical(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginVertical(options);
			block();
			GUILayout.EndVertical();
		}

		public static void VerticalHelpbox(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginVertical(EditorStyles.helpBox, options);
			block();
			GUILayout.EndVertical();
		}

		public static void VerticalBox(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginVertical(UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.BoxSub), options);
			block();
			GUILayout.EndVertical();
		}

		public static void VerticalWhiteBox(Action block, params GUILayoutOption[] options) {
			GUILayout.BeginVertical(UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.WhiteBox), options);
			block();
			GUILayout.EndVertical();
		}

		public static void VerticallyCentered(Action block) {
			Vertical(() => {
				GUILayout.FlexibleSpace();
				block();
				GUILayout.FlexibleSpace();
			});
		}
		
		public static void DisabledBlock(bool active, Action block) {
			GUI.enabled = active;
			block();
			GUI.enabled = true;
		}
		
		public static void DisabledBlock(Action block) {
			GUI.enabled = false;
			block();
			GUI.enabled = true;
		}
	}
}