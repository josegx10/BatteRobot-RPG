using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody rb;
    private Vector3 displacement;
    public float playerRotate;
    public Transform player;
    public Transform collider;
    RaycastHit hit;
    public LayerMask mask;
    public bool isGrounded;
    // Start is called before the first frame update
    void Awake(){
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }
    void FixedUpdate(){
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxisRaw("Vertical");
        
        PlayerMove(mh, mv);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Physics.BoxCast(transform.position, displacement, -player.up, out hit, Quaternion.Euler(collider.eulerAngles), playerSpeed, mask, QueryTriggerInteraction.Ignore)){
            if(hit.collider.tag == "PTK_Cube_2"){
                isGrounded = true;
            }else {
                isGrounded = false;
            }
        } 
        else 
        {
            isGrounded = false;
        }
    }
    void PlayerMove(float mh, float mv){
        displacement = transform.forward * mv + transform.right * mh;
        displacement = displacement.normalized * playerSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + displacement);
        
    }
    void PlayerRotate(float mh){
        float interpolation = playerRotate + Time.deltaTime;
        Vector3 targetDirection = new Vector3(0f,0f,mh);
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection,Vector3.up);
        Quaternion newRotation = Quaternion.Lerp(rb.rotation,targetRotation,interpolation);
        rb.MoveRotation(newRotation);

    }
}
