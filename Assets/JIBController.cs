using System.Collections;
using UnityEngine;

public class JIBController : MonoBehaviour
{
    public Animator animator;             // Animator for the jack-in-the-box animation
    /*public ParticleSystem confetti;*/       // Particle system for the confetti
    /*public float confettiDelay = 2.0f;*/    // Time delay before confetti plays (2 seconds after animation starts)
    private bool isPlaying = false;
    public AudioSource musicBox;

    void Update()
    {
        // Play the animation when the "P" key is pressed
        if (Input.GetKeyDown(KeyCode.P) && !isPlaying)
        {
            animator.Play("JackInTheBox");   // Replace with the actual animation clip name
            isPlaying = true;
            /*StartCoroutine(PlayConfettiWithDelay(confettiDelay));*/ // Start coroutine to delay confetti
            musicBox.Play();
        }
    }

    // Coroutine to delay confetti trigger
    /*
    IEnumerator PlayConfettiWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        confetti.Play();                        // Play the confetti particle system
    }
    */
}


