using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace UserInterfaceTools{
	public class ButtonTool : CreateUIwithCR {
		public enum Kind {standart, textOnly, imageOnly}

		/// <summary>Create a Stardart UI Button object .</summary>
		public GameObject Create(string name, GameObject parent){
			GameObject button = CreateUIwithCRObj(name, parent);
			button.AddComponent<Image>();
			button.AddComponent<Button>();

			TextTool textTool = new TextTool();
			textTool.Create(name, button);
			
			
			return button;
		}

		/// <summary>Create a Optionally Text/Image Only Button UI Button object .</summary>
		public GameObject Create(string name, GameObject parent, Kind kind){
			GameObject button;
			switch (kind){
			case Kind.standart:
				button = Create (name,parent);
				return button;

			case Kind.imageOnly:
				button = CreateUIwithCRObj(name,parent);
				button.AddComponent<Image>();
				return button;

			case Kind.textOnly:
				button = CreateUIwithCRObj(name,parent);
				button.AddComponent<Text>();
				button.GetComponent<Text>().text = name;
				return button;
			 default:
				return Create(name, parent);

			}



		}
		
	}
}
