using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;
    bool isGunPickedUp;

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        if(isGunPickedUp)
            if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger) || (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger)))
            {
                Shoot();
            }
    }


    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.localRotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
        TargetHitFeedback.instance.muzzleFlashEffect.Play();
        TargetHitFeedback.instance.bulletAudioEffect.PlayOneShot(TargetHitFeedback.instance.bulletAudioClip);
    }


    public void CheckGunIsPicked(bool val)
    {
        isGunPickedUp = val;
    }
}
