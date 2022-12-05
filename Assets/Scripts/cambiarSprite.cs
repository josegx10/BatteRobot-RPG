using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarSprite : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate(){
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxisRaw("Vertical");
        anim.SetFloat("VelX",mh);
        anim.SetFloat("VelY", mv);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
