using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitler : MonoBehaviour {
	
	[System.Serializable]
	public struct Subtitle {
		public float time;
		public string displayText;
	}
	
	public Subtitle[] subtitles;
	public Text targetText;
	
	void Start () {
		StartCoroutine(SubTite());
	}
	
	IEnumerator SubTite() {
		for (int i = 0; i < subtitles.Length; i++) {
			targetText.text = subtitles[i].displayText;
			yield return new WaitForSeconds(subtitles[i].time);
		}
		targetText.text = ""; 
	}
}
