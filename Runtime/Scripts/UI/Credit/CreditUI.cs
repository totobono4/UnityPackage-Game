using Totobono4.SceneLoader;
using UnityEngine;
using UnityEngine.UI;

namespace Totobono4.Game.UI {
    public class CreditUI : MonoBehaviour {
        [SerializeField] Button menuButton;

        private void Awake() {
            menuButton.onClick.AddListener(() => {
                SceneLoaderCore.Load(SceneLoaderCore.Scene.MainMenuScene);
            });
        }
    }
}