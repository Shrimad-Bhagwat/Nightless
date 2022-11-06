using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;  
public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float jumpHeight = 3f;

    bool isGrounded;
    public Animator animator;

    public bool checkPoint1;
    public bool checkPoint2;

    public int random;

    AudioSource audioSrc;
    bool isMoving;

    Story story;

    private void Start() {
        animator = GetComponent<Animator>();
        random = Random.Range(0,5);
        audioSrc = GetComponent<AudioSource>();
        story = GetComponent<Story>();
    }
    public int getRandom(){
        return random;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        } 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * Time.deltaTime * speed);

        if(Input.GetButtonDown("Jump") && !isGrounded)
        {
            velocity.y = Mathf.Sqrt(gravity * -2f * jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MENU"); 
        }

        velocity.y += Time.deltaTime * gravity;
        if(move != Vector3.zero)    {
            controller.Move(velocity * Time.deltaTime);
            animator.SetBool("isMoving",true);
            isMoving = true;
        }else{
            animator.SetBool("isMoving",false);
            isMoving = false;
        }

        if(isMoving){
            if(!audioSrc.isPlaying){
                audioSrc.Play();
            }
        }
        else{
            audioSrc.Stop();
        }

    }
    public void cp1_cleared() {
        checkPoint1 = true;
        Debug.Log("Checkpoint 1 Cleared");
        story.SetText("");
    }
    public void cp2_cleared() {
        checkPoint2 = true;
        Debug.Log("Checkpoint 2 Cleared");
        story.SetText("I can feel it's strength just by holding it. Time to go to the next location.");
        
    }
    public bool cp2_check() {
        return checkPoint2;
        
    }

    
}
