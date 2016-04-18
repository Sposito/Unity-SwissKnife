using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class XmlSpriteSlicer : MonoBehaviour {

	[MenuItem("Sprites/Rename Sprites")]



	static void SetSpriteNames()
	{        
		Texture2D myTexture = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Sprites/MyTexture.png");
		TextAsset xml = (TextAsset) AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Sprites/MyTexture.xml");

		XmlDocument document = new XmlDocument();
		document.LoadXml (xml.ToString());



		string path = AssetDatabase.GetAssetPath(myTexture);
		TextureImporter ti = AssetImporter.GetAtPath(path) as TextureImporter;
		ti.isReadable = true;

		List<SpriteMetaData> newData = new List<SpriteMetaData>();

		int SliceWidth = 16;
		int SliceHeight = 16; 



		for (int i = 0; i < document.ChildNodes[0].ChildNodes.Count; i++) {
			string name = document.ChildNodes[0].ChildNodes [i].Attributes [0].Value;
			int x = int.Parse( document.ChildNodes[0].ChildNodes [i].Attributes [1].Value);
			int y = int.Parse( document.ChildNodes[0].ChildNodes [i].Attributes [2].Value);
			int w = int.Parse( document.ChildNodes[0].ChildNodes [i].Attributes [3].Value);
			int h = int.Parse( document.ChildNodes[0].ChildNodes [i].Attributes [4].Value);

			print (string.Format ("{0}, {1}, {2}, {3}, {4} ", name, x, y, w, h));

			SpriteMetaData smd = new SpriteMetaData();
			smd.pivot = new Vector2(0.5f, 0.5f);
			smd.alignment = 9;
			smd.name = name.Split('.')[0];
			smd.rect = new Rect(x,myTexture.height - y -h, w, h);

			if (smd.rect.height > 90) {
				smd.border = Vector4.one * (100f / 3f);
			}

			newData.Add(smd);


		}



//		for (int i = 0; i < myTexture.width; i += SliceWidth)
//		{
//			for(int j = myTexture.height; j > 0;  j -= SliceHeight)
//			{
//				SpriteMetaData smd = new SpriteMetaData();
//				smd.pivot = new Vector2(0.5f, 0.5f);
//				smd.alignment = 9;
//				smd.name = (myTexture.height - j)/SliceHeight + ", " + i/SliceWidth;
//				smd.rect = new Rect(i, j-SliceHeight, SliceWidth, SliceHeight);
//
//				newData.Add(smd);
//			}
//		}

		ti.spritesheet = newData.ToArray();
		AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
	}
}
