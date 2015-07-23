using UnityEngine;
using System.Collections;

namespace UserInterfaceTools{

	public class CreateUI : MonoBehaviour {

		  	public GameObject CreateUIObj(string name, GameObject parent){
			GameObject ui = new GameObject(name);
			RectTransform rect = ui.AddComponent<RectTransform>();
			ui.transform.SetParent(parent.transform);
			return ui;
		}
	
	}
}