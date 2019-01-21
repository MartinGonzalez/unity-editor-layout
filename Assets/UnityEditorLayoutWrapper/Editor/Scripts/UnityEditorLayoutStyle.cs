using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditorLayoutWrapper.Layout.Utilities;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Layout.Style {
	public enum UnityEditorLayoutStyles {
		Button,
		Label,
		BoldLabel,
		BoxSub,
		WhiteBox,
		LabelAlt,
		LabelBlack,
		NegativeButton,
		SearchButton,
		TrashButton,
		PrefabIcon,
		SceneIcon,
		MaterialIcon,
		AnimatorIcon,
		ReferenceButton,
		AssetIcon,
		ScriptIcon,
		ImageIcon,
		WarningIcon,
		H4,
		H3,
		H2,
		HomeButton,
		BackButton
	}

	public static class UnityEditorLayoutStyle {
		private static GUISkin _style;

		private static readonly Dictionary<UnityEditorLayoutStyles, string> StylesMap =
			new Dictionary<UnityEditorLayoutStyles, string>();

		private const string Button = "button";
		private const string Label = "label";
		private const string BoldLabel = "bold-label";
		private const string BoxSub = "box-sub";
		private const string WhiteBox = "white-box";
		private const string LabelAlt = "label-alt";
		private const string LabelBlack = "label-black";
		private const string NegativeButton = "negative-button";
		private const string SearchButton = "search-button";
		private const string TrashButton = "trash-button";
		private const string ReferenceButton = "reference-button";
		private const string PrefabIcon = "prefab-icon";
		private const string SceneIcon = "scene-icon";
		private const string AssetIcon = "asset-icon";
		private const string ScriptIcon = "script-icon";
		private const string ImageIcon = "image-icon";
		private const string MaterialIcon = "material-icon";
		private const string AnimatorIcon = "animator-icon";
		private const string WarningIcon = "warning-icon";
		private const string H4 = "h4";
		private const string H3 = "h3";
		private const string H2 = "h2";
		private const string HomeButton = "home-button";
		private const string BackButton = "back-button";

		static UnityEditorLayoutStyle() {
			StylesMap = new Dictionary<UnityEditorLayoutStyles, string> {
				{UnityEditorLayoutStyles.Button, Button},
				{UnityEditorLayoutStyles.BoxSub, BoxSub},
				{UnityEditorLayoutStyles.WhiteBox, WhiteBox},
				{UnityEditorLayoutStyles.LabelAlt, LabelAlt},
				{UnityEditorLayoutStyles.LabelBlack, LabelBlack},
				{UnityEditorLayoutStyles.NegativeButton, NegativeButton},
				{UnityEditorLayoutStyles.Label, Label},
				{UnityEditorLayoutStyles.BoldLabel, BoldLabel},
				{UnityEditorLayoutStyles.SearchButton, SearchButton},
				{UnityEditorLayoutStyles.TrashButton, TrashButton},
				{UnityEditorLayoutStyles.PrefabIcon, PrefabIcon},
				{UnityEditorLayoutStyles.SceneIcon, SceneIcon},
				{UnityEditorLayoutStyles.MaterialIcon, MaterialIcon},
				{UnityEditorLayoutStyles.AnimatorIcon, AnimatorIcon},
				{UnityEditorLayoutStyles.ReferenceButton, ReferenceButton},
				{UnityEditorLayoutStyles.AssetIcon, AssetIcon},
				{UnityEditorLayoutStyles.ScriptIcon, ScriptIcon},
				{UnityEditorLayoutStyles.ImageIcon, ImageIcon},
				{UnityEditorLayoutStyles.WarningIcon, WarningIcon},
				{UnityEditorLayoutStyles.H4, H4},
				{UnityEditorLayoutStyles.H2, H2},
				{UnityEditorLayoutStyles.H3, H3},
				{UnityEditorLayoutStyles.HomeButton, HomeButton},
				{UnityEditorLayoutStyles.BackButton, BackButton}
			};
		}

		public static GUISkin Skin {
			get {
				if (_style != null) return _style;
				var filePaths = UnityEditorLayoutUtilities.GetFiles("*.guiskin", true);
				var referenceExplorerStylePath =
					filePaths.FirstOrDefault(path => path.Contains("GUIStyle.guiskin"));
				var referenceExplorerStyleRelativePath =
					UnityEditorLayoutUtilities.AbsolutePathToAssetsRelative(referenceExplorerStylePath);
				_style = AssetDatabase.LoadAssetAtPath<GUISkin>(referenceExplorerStyleRelativePath);

				return _style;
			}
		}

		public static string GetStyleFromEnum(UnityEditorLayoutStyles referenceExplorerStyle) {
			return StylesMap[referenceExplorerStyle];
		}

		public static GUIStyle GetCustomStyle(UnityEditorLayoutStyles referenceExplorerStyle) {
			return Skin.customStyles.First(guiStyle => guiStyle.name == GetStyleFromEnum(referenceExplorerStyle));
		}
	}
}