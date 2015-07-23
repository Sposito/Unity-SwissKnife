using UnityEngine;
using System.Collections;
namespace UserInterfaceTools{
	public class CreateUIwithCR : CreateUI {

		public GameObject CreateUIwithCRObj(string name, GameObject parent){
			GameObject uIwithCR = CreateUIObj(name, parent);
			uIwithCR.AddComponent<CanvasRenderer>();
			return uIwithCR;

		}
	}
}