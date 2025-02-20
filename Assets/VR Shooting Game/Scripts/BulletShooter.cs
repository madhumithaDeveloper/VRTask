using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        //if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            Shoot();
        }
    }


    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
        TargetHitFeedback.instance.muzzleFlashEffect.Play();
        TargetHitFeedback.instance.bulletAudioEffect.PlayOneShot(TargetHitFeedback.instance.bulletAudioClip);
    }
}
