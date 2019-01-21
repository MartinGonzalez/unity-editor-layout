using UnityEditor;
using UnityEditorLayoutWrapper.Components;
using UnityEngine;

public class DemoWindow : EditorWindow {
	private string _searchValue;
	
	[MenuItem("Layout/Demo")]
	static void LayoutDemo() {
		GetWindow<DemoWindow>(true, "Demo Window");
	}

	void OnGUI() {
		ComposedLayout.Header("My Header");
		ComposedLayout.MessageBox("Some Message", MessageType.Info);
		_searchValue = ComposedLayout.Search(_searchValue, Color.white);
	}
}
