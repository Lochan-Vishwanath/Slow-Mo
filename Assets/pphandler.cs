using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class pphandler : MonoBehaviour
{
    Bloom bloomLayer = null;

    float bloom_intensity_default = 7;
    float bloom_diffusion_default = 1;

    float bloom_intensity_new = 10;
    float bloom_diffusion_new = 3f;

    public static bool starteffect = false;
    public Camera mainCam;

    void Start()
    {
        PostProcessVolume volume = gameObject.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out bloomLayer);
    }

    // Update is called once per frame
    void Update()
    {
        if (starteffect)
        {
            StartCoroutine("PPeffect");
        }
    }

    IEnumerator PPeffect()
    {
        bloomLayer.intensity.value = bloom_intensity_new;
        bloomLayer.diffusion.value = bloom_diffusion_new;

        mainCam.GetComponent<Animator>().SetTrigger("DoShake");

        yield return new WaitForSeconds(0.1f);

        mainCam.GetComponent<Animator>().ResetTrigger("DoShake");

        bloomLayer.intensity.value = bloom_intensity_default;
        bloomLayer.diffusion.value = bloom_diffusion_default;
        starteffect = false;
    }
}
