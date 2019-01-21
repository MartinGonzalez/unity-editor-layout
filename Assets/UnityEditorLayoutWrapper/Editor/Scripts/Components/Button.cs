using System;
using UnityEditorLayoutWrapper.Layout;
using UnityEditorLayoutWrapper.Layout.Style;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class Button {
		public static void Custom(string label, Action callback, params GUILayoutOption[] options) {
			if (GUILayout.Button(label, UnityEditorLayoutStyle.Skin.button, options))
				callback();
		}

		public static void ReferenceButton(Action callback, params GUILayoutOption[] options) {
			if (GUILayout.Button("", UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.ReferenceButton), options))
				callback();
		}

		public static void SearchButton(Action callback, params GUILayoutOption[] options) {
			if (GUILayout.Button("", UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.SearchButton), options))
				callback();
		}

		public static void TrashButton(Action callback, params GUILayoutOption[] options) {
			if (GUILayout.Button("", UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.TrashButton), options))
				callback();
		}

		public static void HomeButton(Action callback, params GUILayoutOption[] options) {
			if (GUILayout.Button("", UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.HomeButton), options))
				callback();
		}

		public static void BackButton(Action callback, params GUILayoutOption[] options) {
			if (GUILayout.Button("", UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.BackButton), options))
				callback();
		}
	}
}