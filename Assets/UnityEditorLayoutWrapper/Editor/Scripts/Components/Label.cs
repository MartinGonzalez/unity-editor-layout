using UnityEditorLayoutWrapper.Layout;
using UnityEditorLayoutWrapper.Layout.Style;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class Label {
		public static void H2(string label, Color labelColor = default(Color), params GUILayoutOption[] layouts) {
			Custom(label, UnityEditorLayoutStyles.H2, labelColor, layouts);
		}

		public static void H3(string label, Color labelColor = default(Color), params GUILayoutOption[] layouts) {
			Custom(label, UnityEditorLayoutStyles.H3, labelColor, layouts);
		}

		public static void H4(string label, Color labelColor = default(Color), params GUILayoutOption[] layouts) {
			Custom(label, UnityEditorLayoutStyles.H4, labelColor, layouts);
		}

		public static void Bold(string label, params GUILayoutOption[] layouts) {
			Custom(label, UnityEditorLayoutStyles.BoldLabel, default(Color), layouts);
		}

		public static void Bold(string label, Color labelColor = default(Color), params GUILayoutOption[] layouts) {
			Custom(label, UnityEditorLayoutStyles.BoldLabel, labelColor, layouts);
		}

		public static void Custom(string label, params GUILayoutOption[] layouts) {
			Custom(label, UnityEditorLayoutStyles.Label, default(Color), layouts);
		}

		public static void Custom(string label, Color labelColor = default(Color), params GUILayoutOption[] layouts) {
			Custom(label, UnityEditorLayoutStyles.Label, labelColor, layouts);
		}

		public static void Custom(GUIContent content, Color color = default(Color), params GUILayoutOption[] layouts) {
			Custom(content, UnityEditorLayoutStyles.Label, color, layouts);
		}

		public static void Custom(GUIContent content, params GUILayoutOption[] layouts) {
			Custom(content, UnityEditorLayoutStyles.Label, default(Color), layouts);
		}

		public static void Bold(GUIContent content, params GUILayoutOption[] layouts) {
			Custom(content, UnityEditorLayoutStyles.BoldLabel, default(Color), layouts);
		}

		public static void Bold(GUIContent content, Color labelColor = default(Color),
			params GUILayoutOption[] layouts) {
			Custom(content, UnityEditorLayoutStyles.BoldLabel, labelColor, layouts);
		}

		public static void Custom(string label, UnityEditorLayoutStyles style = UnityEditorLayoutStyles.Label,
			Color labelColor = default(Color),
			params GUILayoutOption[] layouts) {
			var customSyle = UnityEditorLayoutStyle.GetCustomStyle(style);
			customSyle.normal.textColor = labelColor != default(Color) ? labelColor : customSyle.normal.textColor;
			GUILayout.Label(label, customSyle, layouts);
		}

		public static void Custom(GUIContent content, UnityEditorLayoutStyles style = UnityEditorLayoutStyles.Label,
			Color labelColor = default(Color), params GUILayoutOption[] layouts) {
			var customSyle = UnityEditorLayoutStyle.GetCustomStyle(style);
			customSyle.normal.textColor = labelColor != default(Color) ? labelColor : customSyle.normal.textColor;
			GUILayout.Label(content, customSyle, layouts);
		}
	}
}