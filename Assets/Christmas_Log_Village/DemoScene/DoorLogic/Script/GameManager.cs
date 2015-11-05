using UnityEngine;
using System.Collections;


public enum HouseTypesEnum
{
	HouseA,HouseB,HouseC,HouseD,HouseE,HouseF
}

public class GameManager : MonoBehaviour {
	

	public Vector3 LastDoor;

	public Quaternion PlayerRotation;
	
	//houses
	public Transform HouseASpawn;
	public Transform HouseBSpawn;
	public Transform HouseCSpawn;
	public Transform HouseDSpawn;
	public Transform HouseESpawn;
	public Transform HouseFSpawn;

	public HouseTypesEnum HouseTypeTarget;

	private int lastLevel = 0;

		
	public AudioClip MainMusic;



	// Use this for initialization
	void Start () {

		DontDestroyOnLoad(transform.gameObject);

		Application.LoadLevel(1);

	
	}

	public void OnLevelWasLoaded(int level){

		if(level == 1){

			if(lastLevel ==0){
				PlayerRotation = Quaternion.Euler(new Vector3(0,PlayerRotation.y,0));
			}

			GameObject.Find("_First Person Controller").transform.rotation = PlayerRotation;
			GameObject.Find("_First Person Controller").transform.position = LastDoor;

			lastLevel = 1;

			this.GetComponent<AudioSource>().volume = 0.5f;

				//this.audio.clip = MainMusic;
				//this.audio.Play ();



		}

		if(level == 2){
			lastLevel = 2;

			//this.audio.clip = InteriorMusic;
			//this.audio.Play ();

			this.GetComponent<AudioSource>().volume = 0.3f;

			if(this.HouseTypeTarget == HouseTypesEnum.HouseA)
				GameObject.Find("_First Person Controller").transform.position = HouseASpawn.position;
			else if(this.HouseTypeTarget == HouseTypesEnum.HouseB)
				GameObject.Find("_First Person Controller").transform.position = HouseBSpawn.position;
			else if(this.HouseTypeTarget == HouseTypesEnum.HouseC)
				GameObject.Find("_First Person Controller").transform.position = HouseCSpawn.position;
			else if(this.HouseTypeTarget == HouseTypesEnum.HouseD)
				GameObject.Find("_First Person Controller").transform.position = HouseDSpawn.position;
			else if(this.HouseTypeTarget == HouseTypesEnum.HouseE)
				GameObject.Find("_First Person Controller").transform.position = HouseESpawn.position;
			else if(this.HouseTypeTarget == HouseTypesEnum.HouseF)
				GameObject.Find("_First Person Controller").transform.position = HouseFSpawn.position;


		}


	}

}
