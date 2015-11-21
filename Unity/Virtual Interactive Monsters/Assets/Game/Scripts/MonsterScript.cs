using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {

    public float movement_constant;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        float x_movement = 0;
        float y_movement = 0;

	    if (Input.GetKey(KeyCode.UpArrow)) {
            y_movement += movement_constant;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            y_movement -= movement_constant;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            x_movement -= movement_constant;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x_movement += movement_constant;
        }
        transform.Translate(x_movement, y_movement, 0);
    }
}
