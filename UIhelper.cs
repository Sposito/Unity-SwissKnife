using UnityEngine;
using System.Collections;
using UnityEngine.UI;

class UIhelper{
	public UIhelper()
	{

	}

	public Vector2 calculatePivot(Sprite s){
		float resultX, resultY;

		resultX = s.pivot.x  / s.rect.width ;
		resultY = s.pivot.y / s.rect.height ;

		return new Vector2(resultX,resultY);
	}
}
