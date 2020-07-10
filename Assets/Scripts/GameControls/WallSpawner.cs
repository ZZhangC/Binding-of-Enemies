using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject basement011;
    public GameObject basement012;
    public GameObject basement013;
    public GameObject basement_nfloor011;
    void Start()
    {
        GameObject[] basement = new GameObject[4];
        basement[0] = GameObject.Instantiate(basement011);
        basement[1] = GameObject.Instantiate(basement011);
        basement[2] = GameObject.Instantiate(basement011);
        basement[3] = GameObject.Instantiate(basement011);

        basement[0].transform.localScale = new Vector3(3.8f, 3.2f, 1.0f);
        basement[1].transform.localScale = new Vector3(3.8f, 3.2f, 1.0f);
        basement[2].transform.localScale = new Vector3(3.8f, 3.2f, 1.0f);
        basement[3].transform.localScale = new Vector3(3.8f, 3.2f, 1.0f);

        basement[1].transform.Rotate(0, 180, 0);
        basement[2].transform.Rotate(180, 0, 0);
        basement[3].transform.Rotate(180, 180, 0);

        basement[0].transform.position = new Vector3(this.transform.position.x + 0, this.transform.position.y + 0, this.transform.position.z + 0);
        basement[1].transform.position = new Vector3(this.transform.position.x + 17.78f, this.transform.position.y + 0, this.transform.position.z + 0);
        basement[2].transform.position = new Vector3(this.transform.position.x + 0, this.transform.position.y + -9.98f, this.transform.position.z + 0);
        basement[3].transform.position = new Vector3(this.transform.position.x + 17.78f, this.transform.position.y - 9.98f, this.transform.position.z + 0);
    }

    void Update()
    {
        
    }
}
