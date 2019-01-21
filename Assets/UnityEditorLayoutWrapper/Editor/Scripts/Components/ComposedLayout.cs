using System;
using UnityEditor;
using UnityEditorLayoutWrapper.Layout;
using UnityEditorLayoutWrapper.Layout.Style;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class ComposedLayout {
		public static void Header(string title, Color color = default(Color)) {
			color = color == default(Color) ? Color.white : color;
			Layout.HorizontalBox(() => Layout.HorizontallyCentered(() => Label.Bold(title, color)));
		}

		public static void H3Header(string title, Color color = default(Color)) {
			Layout.HorizontalBox(() => { Label.H3(title, color); });
		}

		public static void H4Header(string title, Color color = default(Color)) {
			Layout.HorizontalBox(() => { Label.H4(title, color); });
		}

		public static void CenteredH3Header(string title, Color color = default(Color)) {
			Layout.HorizontalBox(() => { Layout.HorizontallyCentered(() => { Label.H3(title, color); }); });
		}

		public static void CenteredH4Header(string title, Color color = default(Color)) {
			Layout.HorizontalBox(() => { Layout.HorizontallyCentered(() => { Label.H4(title, color); }); });
		}

		public static string Search(string searchValue, Color color = default(Color),
			params GUILayoutOption[] layouts) {
			Layout.HorizontalBox(() => {
				Label.Custom("Search", default(Color), layouts);
				searchValue = GUILayout.TextField(searchValue);
			});
			return searchValue;
		}

		public static string Search(string searchValue, params GUILayoutOption[] layouts) {
			Layout.HorizontalBox(() => {
				Label.Custom("Search", default(Color), layouts);
				searchValue = GUILayout.TextField(searchValue);
			});
			return searchValue;
		}

		public static void Line() {
			Layout.Horizontal(() => {
				Layout.HorizontallyCentered(() => {
					Label.Custom(
						"_______________________________________________________________________________________");
				});
			});
		}

		public static void Foldeable(ref bool value, string label, Action block, Color color = default(Color),
			params GUILayoutOption[] options) {
			var toggle = value;
			Layout.Horizontal(() => {
				Label.Custom(label, color, options);
				toggle = GUILayout.Toggle(toggle, "", UnityEditorLayoutStyle.Skin.toggle,
					GUILayout.MaxWidth(10),
					GUILayout.MaxHeight(10));
			});
			value = toggle;
			if (!value) return;
			block();
		}
		
		[Obsolete("Use Method passing the block")]
		public static bool FoldeableH2(bool value, string label, Color color = default(Color),
			params GUILayoutOption[] options) {
			var toggle = value;
			Layout.Horizontal(() => {
				Label.H2(label, color, options);
				toggle = GUILayout.Toggle(value, "", UnityEditorLayoutStyle.Skin.toggle,
					GUILayout.MaxWidth(10),
					GUILayout.MaxHeight(10));
			});
			return toggle;
		}

		public static void FoldeableH2(ref bool value, string label, Action block, Color color = default(Color),
			params GUILayoutOption[] options) {
			var toggle = value;
			Layout.Horizontal(() => {
				Label.H2(label, color, options);
				toggle = GUILayout.Toggle(toggle, "", UnityEditorLayoutStyle.Skin.toggle,
					GUILayout.MaxWidth(10),
					GUILayout.MaxHeight(10));
			});
			value = toggle;
			if (!value) return;
			block();
		}

		[Obsolete("Use Method passing the block")]
		public static bool FoldeableH3(bool value, string label, Color color = default(Color),
			params GUILayoutOption[] options) {
			var toggle = value;
			Layout.Horizontal(() => {
				Label.H3(label, color, options);
				toggle = GUILayout.Toggle(value, "", UnityEditorLayoutStyle.Skin.toggle,
					GUILayout.MaxWidth(10),
					GUILayout.MaxHeight(10));
			});
			return toggle;
		}
		
		public static void FoldeableH3(ref bool value, string label, Action block, Color color = default(Color),
			params GUILayoutOption[] options) {
			var toggle = value;
			Layout.Horizontal(() => {
				Label.H3(label, color, options);
				toggle = GUILayout.Toggle(toggle, "", UnityEditorLayoutStyle.Skin.toggle,
					GUILayout.MaxWidth(10),
					GUILayout.MaxHeight(10));
			});
			value = toggle;
			if (!value) return;
			block();
		}

		[Obsolete("Use Method passing the block")]
		public static bool FoldeableH4(bool value, string label, Color color = default(Color),
			params GUILayoutOption[] options) {
			var toggle = value;
			Layout.Horizontal(() => {
				Label.H4(label, color, options);
				toggle = GUILayout.Toggle(value, "", UnityEditorLayoutStyle.Skin.toggle,
					GUILayout.MaxWidth(10),
					GUILayout.MaxHeight(10));
			});
			return toggle;
		}
		
		public static void FoldeableH4(ref bool value, string label, Action block, Color color = default(Color),
			params GUILayoutOption[] options) {
			var toggle = value;
			Layout.Horizontal(() => {
				Label.H4(label, color, options);
				toggle = GUILayout.Toggle(toggle, "", UnityEditorLayoutStyle.Skin.toggle,
					GUILayout.MaxWidth(10),
					GUILayout.MaxHeight(10));
			});
			value = toggle;
			if (!value) return;
			block();
		}
	
		public static void MessageBox(string label, MessageType messageType) {
			EditorGUILayout.HelpBox(label, messageType);
		}
	}
}