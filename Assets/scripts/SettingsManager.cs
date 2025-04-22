using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Toggle muteToggle;

    private void Start(){
        volumeSlider.value = AudioListener.volume;
        muteToggle.isOn = AudioListener.volume == 0;

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        muteToggle.onValueChanged.AddListener(OnMuteChanged);
    }

    private void OnVolumeChanged(float value){
        AudioListener.volume = value;
    }

    private void OnMuteChanged(bool isMuted){
        AudioListener.volume = isMuted ? 0 : volumeSlider.value;
    }
}
