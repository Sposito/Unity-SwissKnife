using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace UserInterfaceTools{
	public class TextTool : CreateUIwithCR {
		
		/// <summary>Create a UI Button object .</summary>
		public GameObject Create(string name, GameObject parent){
			GameObject button = CreateUIwithCRObj(name, parent);
			button.AddComponent<Text>();
			button.GetComponent<Text>().text = name;
			
			return button;
		}
		
	}
}
