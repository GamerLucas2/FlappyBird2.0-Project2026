using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance  { get; private set; }
    
    [SerializeField] private AudioSource audioSource;
    
    [Header("Audio Clips")]
    [SerializeField] private AudioClip fly;
    [SerializeField] private AudioClip hit;
    [SerializeField] private AudioClip die;
    [SerializeField] private AudioClip score;
    
    
    private void Awake()
    {
        Instance = this;
        
        audioSource = GetComponent<AudioSource>();
    }
    
    // PLay Audio
    public void PlayFlyingSound() => audioSource.PlayOneShot(fly);
    public void PlayHitSound() => audioSource.PlayOneShot(hit);
    public void PlayDieSound() => audioSource.PlayOneShot(die);
    public void PlayScoreSound() => audioSource.PlayOneShot(score);
    
    
    
    
}
