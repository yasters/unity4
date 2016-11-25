using UnityEngine;
using System.Collections;

public class KillTarget : MonoBehaviour {
	public GameObject target;
	public ParticleSystem hitEffect;
	public GameObject killEffect;
	public float timeToSelect = 3.0f;
	public int score;

	private ParticleSystem.EmissionModule hitEffectEmission;
	private float countDown;

	// Use this for initialization
	void Start () {
		score = 0;
		countDown = timeToSelect;
		hitEffectEmission = hitEffect.emission;
		hitEffectEmission.enabled = false;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
