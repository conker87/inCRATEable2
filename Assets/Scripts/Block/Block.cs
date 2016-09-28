using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public BlockType blockType;
	public float blockHealth = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public enum BlockType { GLASS, WOOD, STONE, METAL, ELEMENTAL };