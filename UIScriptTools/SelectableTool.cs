using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace UserInterfaceTools{
	public class SelectableTool : CreateUIwithCR {
		
		/// <summary>Create a UI Button object .</summary>
		public GameObject Create(string name, GameObject parent){
			GameObject button = CreateUIwithCRObj(name, parent);
			button.AddComponent<Selectable>();

			
			return button;
		}
		
	}
}
