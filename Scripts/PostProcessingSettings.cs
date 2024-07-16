using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingSettings : MonoBehaviour
{
    [SerializeField]
    private AmbientOcclusion ambientOcclusion;

    [SerializeField]
    private Bloom bloom;

    [SerializeField]
    private Vignette vignette;

    [SerializeField]
    private PostProcessVolume volume;

    private void Awake()
    {
        volume.profile.TryGetSettings(out ambientOcclusion);
        volume.profile.TryGetSettings(out bloom);
        volume.profile.TryGetSettings(out vignette);
    }

    public void TurnAmbientOcclusion(bool value)
    {
        ambientOcclusion.active = value;
    }
    public void TurnBloom(bool value)
    {
        bloom.active = value;
    }
    public void TurnVignette(bool value)
    {
        vignette.active = value;
    }
}
