using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject graveStone0;
	public GameObject graveStone1;
	public GameObject graveStone2;
	public GameObject graveStone3;
	private GameObject [,] graveyard;

	// Use this for initialization
	void Start () {
	
		generateGraveyard();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generateGraveyard(){

		graveyard = new GameObject[6,6];

		for(int i = 0; i < 6; i ++){
			for (int j = 0; j < 6; j ++){

				GameObject gs = getRandomGravestone();
				Vector3 pos = new Vector3(i*8f,0.2f,j*6f);
				Quaternion rot = Quaternion.AngleAxis(-10f,Vector3.up);

				graveyard[i,j] = gs;

				Instantiate(gs,pos,Quaternion.identity);
			}
		}
	}


	GameObject getRandomGravestone(){

		GameObject gs = graveStone0;

		int graveno = Random.Range(0,4);

		switch(graveno){
		case 0:
			gs = graveStone0;
			break;
		case 1:
			gs = graveStone1;
			break;
		case 2:
			gs = graveStone2;
			break;
		case 3:
			gs = graveStone3;
			break;
		}

		return gs;
		
	}

}
