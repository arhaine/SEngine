using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempAssembler : MonoBehaviour
{

	public CharacterLocationContainer MyChar;

	// Use this for initialization
	void Start () {
		MyChar = new HumanoidTorsoLocation(null);
	}
}
