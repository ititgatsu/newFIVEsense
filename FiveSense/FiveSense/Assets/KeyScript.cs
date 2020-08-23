using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyScript : MonoBehaviour
{
    public bool HavingKey;
    public int DoorCount;
    public int Life;
    public float SafeTime;
    public GameObject[] LifeIcons;
    public GameObject KeySprite;
    public int DeathCount;
    public AudioClip GetKey;
    public AudioClip Escape;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        HavingKey = false;
        KeySprite.SetActive(false);
        DoorCount = 0;
        Life = 3;
        SafeTime = 0.0f;
        DeathCount = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SafeTime > 0)
        {
            SafeTime -= Time.deltaTime;
        }
        if (Life < 0)
        {
            SceneManager.LoadScene("GAMEOVER");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key" && HavingKey == false)
        {
            HavingKey = true;
            KeySprite.SetActive(true);
            audioSource.PlayOneShot(GetKey);
            Destroy(other.gameObject);
        }
        if (other.tag == "Door" && HavingKey == true)
        {
            HavingKey = false;
            KeySprite.SetActive(false);
            DoorCount += 1;
            if (DoorCount >= 4)
            {
                audioSource.PlayOneShot(Escape);
                Destroy(other.gameObject);
                SceneManager.LoadScene("GAMECLEAR");
            }
        }
        if (other.tag == "Enemy" && SafeTime <= 0)
        {
            Life -= 1;
            SafeTime = 1.0f;
            DeathCount += 1;
            ChangeIcons();
        }
    }

    void ChangeIcons()
    {
        for (int i = 0; i < LifeIcons.Length; i++)
        {
            if (DeathCount <= i)
            {
                LifeIcons[i].SetActive(true);
            }
            else
            {
                LifeIcons[i].SetActive(false);
            }
        }
    }
}
