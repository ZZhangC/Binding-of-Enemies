using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class teas_controller : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public GameObject Player;
    public Vector2 VectorToPlayer;
    public GameObject Effect;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
        VectorToPlayer = (Player.transform.position - this.transform.position) * 5;
        this.transform.localScale = new Vector3(3, 3, 1);
        Rigidbody2D.AddForce(VectorToPlayer);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject TmpEffect = GameObject.Instantiate(Effect);
        TmpEffect.transform.position = this.transform.position;
        TmpEffect.transform.localScale = new Vector3(3, 3, 1);
        Destroy(gameObject);
    }
}
