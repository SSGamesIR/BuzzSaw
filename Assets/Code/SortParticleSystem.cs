using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortParticleSystem : MonoBehaviour
{
	public string LayerName = "Particles";
	private ParticleSystem ps;
	private ParticleSystemRenderer psr;

	public void Start()
	{
		ps = GetComponent<ParticleSystem>();
		psr = GetComponent<ParticleSystemRenderer>();
		psr.sortingLayerName = LayerName;
	}


}
