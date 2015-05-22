using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	// Use this for initialization
	public GameObject sample;

	void Start () {
		int mp[110][110];
		int width = 100, height = 100;

		//make walls around
		for (int i=1; i<=width; ++i) {
			mp[0][i]=-1;
			mp[height][i]=-1;
		}
		for (int i=1; i<=height; ++i) {
			mp[i][0]=-1;
			mp[i][width]=-1;
		}

		Random(100);

		/*
		for (int i=-5; i<=5; ++i)
			for (int j=-5; j<=5; ++j)
				if (j%3==0)
					GameObject.Instantiate (sample,
					                        new Vector3(100+i*2, 1, 100+j*2),
				             	 			Quaternion.identity);
		GameObject.Destroy (sample);
		*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
