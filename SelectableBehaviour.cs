using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary> Base Class which implements common User Iterface Button Behaviours. </summary>
[RequireComponent (typeof (Selectable))]
public class SelectableBehaviour : MonoBehaviour {

	/// <summary> Public method which resets the current EventSystem selected Selectable </summary>
	public void Unselect(){
		try {
			GameObject myEventSystem = GameObject.Find("EventSystem");
			myEventSystem.GetComponent<EventSystem>().SetSelectedGameObject(null);
		}

		catch( System.NullReferenceException e){
			Debug.LogWarning(e.Message + "  (Maybe you Renamed Your Event System?)");
		}
	}
}
