using UnityEditor;
using UnityEditorLayoutWrapper.Layout.Style;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Components {
	public static class Icon {
		private static int iconSize = 25;

		public static void FromStyle(UnityEditorLayoutStyles style) {
			GUILayout.Label("", UnityEditorLayoutStyle.GetCustomStyle(style));
		}
		
		public static void Warning(string hoverMessage = "") {
			GUILayout.Label(new GUIContent("", hoverMessage),
				UnityEditorLayoutStyle.GetCustomStyle(UnityEditorLayoutStyles.WarningIcon),
				GUILayout.MaxWidth(iconSize), GUILayout.MaxHeight(iconSize));
		}

		public static void ForExtension(string fileExtension) {
			switch (fileExtension) {
				case "folder":
				case "dir":
				case "directory":
					IconLabel(EditorGUIUtility.FindTexture("Folder Icon"));
					break;
				case "boo":
					IconLabel(EditorGUIUtility.FindTexture("boo Script Icon"));
					break;
				case "cginc":
					IconLabel(EditorGUIUtility.FindTexture("CGProgram Icon"));
					break;
				case "cs":
					IconLabel(EditorGUIUtility.FindTexture("cs Script Icon"));
					break;
				case "guiskin":
					IconLabel(EditorGUIUtility.FindTexture("GUISkin Icon"));
					break;
				case "js":
					IconLabel(EditorGUIUtility.FindTexture("Js Script Icon"));
					break;
				case "mat":
					IconLabel(EditorGUIUtility.FindTexture("Material Icon"));
					break;
				case "prefab":
					IconLabel(EditorGUIUtility.FindTexture("PrefabNormal Icon"));
					break;
				case "shader":
					IconLabel(EditorGUIUtility.FindTexture("Shader Icon"));
					break;
				case "txt":
					IconLabel(EditorGUIUtility.FindTexture("TextAsset Icon"));
					break;
				case "unity":
					IconLabel(EditorGUIUtility.FindTexture("SceneAsset Icon"));
					break;
				case "asset":
				case "prefs":
					IconLabel(EditorGUIUtility.FindTexture("GameManager Icon"));
					break;
				case "anim":
					IconLabel(EditorGUIUtility.FindTexture("Animation Icon"));
					break;
				case "controller":
					IconLabel(EditorGUIUtility.FindTexture("AnimatorController Icon"));
					break;
				case "meta":
					IconLabel(EditorGUIUtility.FindTexture("MetaFile Icon"));
					break;
				case "ttf":
				case "otf":
				case "fon":
				case "fnt":
					IconLabel(EditorGUIUtility.FindTexture("Font Icon"));
					break;
				case "aac":
				case "aif":
				case "aiff":
				case "au":
				case "mid":
				case "midi":
				case "mp3":
				case "mpa":
				case "ra":
				case "ram":
				case "wma":
				case "wav":
				case "wave":
				case "ogg":
					IconLabel(EditorGUIUtility.FindTexture("AudioClip Icon"));
					break;
				case "ai":
				case "apng":
				case "png":
				case "bmp":
				case "cdr":
				case "dib":
				case "eps":
				case "exif":
				case "gif":
				case "ico":
				case "icon":
				case "j":
				case "j2c":
				case "j2k":
				case "jas":
				case "jiff":
				case "jng":
				case "jp2":
				case "jpc":
				case "jpe":
				case "jpeg":
				case "jpf":
				case "jpg":
				case "jpw":
				case "jpx":
				case "jtf":
				case "mac":
				case "omf":
				case "qif":
				case "qti":
				case "qtif":
				case "tex":
				case "tfw":
				case "tga":
				case "tif":
				case "tiff":
				case "wmf":
				case "psd":
				case "exr":
					IconLabel(EditorGUIUtility.FindTexture("Texture Icon"));
					break;
				case "3df":
				case "3dm":
				case "3dmf":
				case "3ds":
				case "3dv":
				case "3dx":
				case "blend":
				case "c4d":
				case "lwo":
				case "lws":
				case "ma":
				case "max":
				case "mb":
				case "mesh":
				case "obj":
				case "vrl":
				case "wrl":
				case "wrz":
				case "fbx":
					IconLabel(EditorGUIUtility.FindTexture("Mesh Icon"));
					break;
				case "asf":
				case "asx":
				case "avi":
				case "dat":
				case "divx":
				case "dvx":
				case "mlv":
				case "m2l":
				case "m2t":
				case "m2ts":
				case "m2v":
				case "m4e":
				case "m4v":
				case "mjp":
				case "mov":
				case "movie":
				case "mp21":
				case "mp4":
				case "mpe":
				case "mpeg":
				case "mpg":
				case "mpv2":
				case "ogm":
				case "qt":
				case "rm":
				case "rmvb":
				case "wmw":
				case "xvid":
					IconLabel(EditorGUIUtility.FindTexture("MovieTexture Icon"));
					break;
				case "spriteatlas":
					IconLabel(EditorGUIUtility.FindTexture("SpriteAtlas Icon"));
					break;
				case "colors":
				case "gradients":
				case "curves":
				case "curvesnormalized":
				case "particlecurves":
				case "particlecurvessigned":
				case "particledoublecurves":
				case "particledoublecurvessigned":
					IconLabel(EditorGUIUtility.FindTexture("ScriptableObject Icon"));
					break;
				default:
					IconLabel(EditorGUIUtility.FindTexture("DefaultAsset Icon"));
					break;
			}
		}

		private static void IconLabel(Texture2D iconTexture) {
			GUILayout.Label(iconTexture, GUILayout.MaxWidth(iconSize), GUILayout.MaxHeight(iconSize));
		}
	}
}