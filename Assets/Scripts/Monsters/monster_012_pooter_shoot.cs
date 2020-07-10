using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;

public class monster_012_pooter_shoot : MonoBehaviour
{
    public float Shoot_Timer;
    public Animator Animator;
    public GameObject pfbBullet;

    public void PooterShoot()
    {
        GameObject tmpBullet = GameObject.Instantiate(pfbBullet);
        tmpBullet.transform.position = this.transform.position;
        return;
    }

    public void PooterEndShoot()
    {
        Shoot_Timer = 0;
        Animator.SetBool("IsOnShoot", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Shoot_Timer = 0.0f;
        Animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot_Timer += 10 * Time.deltaTime;
        if(Shoot_Timer >= 8)
        {
            Animator.SetBool("IsOnShoot", true);
        }
    }
}
