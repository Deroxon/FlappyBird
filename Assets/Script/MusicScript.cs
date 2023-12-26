using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicScript : MonoBehaviour
{

    private AudioSource audioSource;

    public Sprite speaker, Unspeaker;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Debug.Log("głośnik");
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            spriteRenderer.sprite = Unspeaker;
        }
        else
        {
            audioSource.Play();
            spriteRenderer.sprite = speaker;
        }
    }

}
