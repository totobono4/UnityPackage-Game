using Totobono4.SceneLoader;
using UnityEngine;
using UnityEngine.UI;

namespace Totobono4.Game.UI {
    public class MenuUI : MonoBehaviour {
        [SerializeField] protected Button playButton;
        [SerializeField] private Button creditButton;
        [SerializeField] private Button quitButton;

        protected virtual void Awake() {
            creditButton.onClick.AddListener(() => {
                SceneLoaderCore.Load(SceneLoaderCore.Scene.CreditScene);
            });
            quitButton.onClick.AddListener(() => {
                Application.Quit();
            });
        }
    }
}