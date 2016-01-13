using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class ImageDownloader : MonoBehaviour
{
	IEnumerator Start()
	{
		RawImage rawImage = GetComponent<RawImage>();

		Debug.Log (Application.persistentDataPath + "/app.png");

		byte[] bytes = File.ReadAllBytes(Application.persistentDataPath + "/app.png");
		Texture2D texture = new Texture2D(200, 200);
		texture.filterMode = FilterMode.Trilinear;
		texture.LoadImage(bytes);

		rawImage.texture = texture;
		rawImage.SetNativeSize();

		yield return null;
	}
}
