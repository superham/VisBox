using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;
using MiddleVR_Unity3D;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class PlayerShooting : MonoBehaviour
    {
        public int damagePerShot = 20;                  // The damage inflicted by each bullet.
        public float timeBetweenBullets = 0.15f;        // The time between each shot.
        public float range = 100f;                      // The distance the gun can fire.
		public int ammo = 500;
		public Slider ammoSlider;  

        float timer;                                    // A timer to determine when to fire.
        Ray shootRay;                                   // A ray from the gun end forwards.
        RaycastHit shootHit;                            // A raycast hit to get information about what was hit.
        int shootableMask;                              // A layer mask so the raycast only hits things on the shootable layer.
        ParticleSystem gunParticles;                    // Reference to the particle system.
        LineRenderer gunLine;                           // Reference to the line renderer.
        AudioSource gunAudio;                           // Reference to the audio source.
        Light gunLight;                                 // Reference to the light component.
        float effectsDisplayTime = 0.2f;                // The proportion of the timeBetweenBullets that the effects will display for.


        void Awake ()
        {
            // Create a layer mask for the Shootable layer.
            shootableMask = LayerMask.GetMask ("Shootable");

            // Set up the references.
            gunParticles = GetComponent<ParticleSystem> ();
            gunLine = GetComponent <LineRenderer> ();
            gunAudio = GetComponent<AudioSource> ();
            gunLight = GetComponent<Light> ();
			GameObject Wand = GameObject.Find("VRWand");
        }


        void Update ()
        {
//			shootRay.direction  =  m_RefNode.transform.
			//var VRMgrObject : GameObject = GameObject.Find("VRManager");
			//var VRMgr : VRManagerScript;
			//GameObject VRMgrObject = GameObject.Find("VRManager");
			//VRManagerScript VRMgr = VRMgrObject.GetComponent("VRManagerScript");

            // Add the time since Update was last called to the timer.
            timer += Time.deltaTime;

#if !MOBILE_INPUT
            // If the Fire1 button is being press and it's time to fire...
			//if(Input.GetButton ("Fire1") && timer >= timeBetweenBullets && Time.timeScale != 0)
			if(MiddleVR.VRDeviceMgr.IsWandButtonPressed(0) && timer >= timeBetweenBullets && Time.timeScale != 0)
            {
                // ... shoot the gun.
				if(ammo> 0)
				{
                	Shoot ();
					ammo--;
				}
            }
#else
            // If there is input on the shoot direction stick and it's time to fire...
            if ((CrossPlatformInputManager.GetAxisRaw("Mouse X") != 0 || CrossPlatformInputManager.GetAxisRaw("Mouse Y") != 0) && timer >= timeBetweenBullets)
            {
                // ... shoot the gun
                Shoot();
            }
#endif
            // If the timer has exceeded the proportion of timeBetweenBullets that the effects should be displayed for...
            if(timer >= timeBetweenBullets * effectsDisplayTime)
            {
                // ... disable the effects.
                DisableEffects ();
            }
        }


        public void DisableEffects ()
        {
            // Disable the line renderer and the light.
            gunLine.enabled = false;
            gunLight.enabled = false;
        }


        void Shoot ()
        {
			GameObject m_RefNode = GameObject.Find("HandNode");
			//Vector3 directionVector = new Vector3(0, 0, 1);
			shootRay.direction  =  m_RefNode.transform.forward;
            // Reset the timer.
            timer = 0f;

            // Play the gun shot audioclip.
            gunAudio.Play ();

            // Enable the light.
            gunLight.enabled = true;

			ammoSlider.value = ammo;

            // Stop the particles from playing if they were, then start the particles.
            gunParticles.Stop ();
            gunParticles.Play ();

            // Enable the line renderer and set it's first position to be the end of the gun.
            gunLine.enabled = true;
            gunLine.SetPosition (0, transform.position);

            // Set the shootRay so that it starts at the end of the gun and points forward from the barrel.
			shootRay.origin = m_RefNode.transform.position;
			//shootRay.direction = m_RefNode.transform.TransformDirection(directionVector);
            //shootRay.direction = transform.forward;

            // Perform the raycast against gameobjects on the shootable layer and if it hits something...
            if(Physics.Raycast (shootRay, out shootHit, range, shootableMask))
            {
                // Try and find an EnemyHealth script on the gameobject hit.
                EnemyHealth enemyHealth = shootHit.collider.GetComponent <EnemyHealth> ();

                // If the EnemyHealth component exist...
                if(enemyHealth != null)
                {
                    // ... the enemy should take damage.
                    enemyHealth.TakeDamage (damagePerShot, shootHit.point);
                }

                // Set the second position of the line renderer to the point the raycast hit.
                gunLine.SetPosition (1, shootHit.point);
            }
            // If the raycast didn't hit anything on the shootable layer...
            else
            {
                // ... set the second position of the line renderer to the fullest extent of the gun's range.
                gunLine.SetPosition (1, shootRay.origin + shootRay.direction * range);
            }
        }
    }
}
