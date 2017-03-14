using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glower : MonoBehaviour {
	[System.Serializable]
	public struct GlowPack {
		public GameObject glow;
		public float[] times;
		public bool startOn;
	}
	
	public GlowPack[] glows;
	
	void Start () {
		for (int i = 0; i < glows.Length; i++) {
			StartCoroutine(Timify(glows[i]));
		}
	}
	
	IEnumerator Timify (GlowPack target) {
		target.glow.SetActive(target.startOn);
		for (int i = 0; i < target.times.Length; i++) {
			yield return new WaitForSeconds(target.times[i]);
			target.glow.SetActive(!target.glow.activeInHierarchy);
		}
	}
}
