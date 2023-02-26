using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    [Header("Shooting")]
    [SerializeField] AudioClip playerShootingClip;
    [SerializeField] AudioClip enemyShootingClip;
    [SerializeField] [Range(0f, 1f)] float shootingVolume = 1f;
    
    [Header("Damage")]
    [SerializeField] AudioClip playerDamageClip;
    [SerializeField] AudioClip enemyDamageClip;
    [SerializeField] [Range(0f, 1f)] float damageVolume = 1f;

    public void PlayPlayerShootingClip()
    {
        PlayClip(playerShootingClip, shootingVolume);
    }
    
    public void PlayEnemyShootingClip()
    {
        PlayClip(enemyShootingClip, shootingVolume);
    }
    
    public void PlayPlayerDamageClip()
    {
        PlayClip(playerDamageClip, damageVolume);
    }
    public void PlayEnemyDamageClip()
    {
        PlayClip(enemyDamageClip, damageVolume);
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
    }

}
