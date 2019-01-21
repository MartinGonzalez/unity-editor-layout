using System.IO;
using UnityEngine;

namespace UnityEditorLayoutWrapper.Layout.Utilities {
	public static class UnityEditorLayoutUtilities {
		private static readonly string projectRootPath;

		static UnityEditorLayoutUtilities() {
			projectRootPath = Application.dataPath;
		}

		public static string[] GetFiles(string fileExtension, bool recursive) {
			return Directory.GetFiles(projectRootPath, fileExtension,
				recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
		}

		public static string AbsolutePathToAssetsRelative(string filePath) {
			return filePath.Replace(projectRootPath, "Assets");
		}
		
		public static string LimitStringTo(int maxChars, string value) {
			if (value.Length <= maxChars) return value;
			return value.Remove(maxChars) + "...";
		}
	}
}