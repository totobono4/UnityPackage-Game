using System;
using Totobono4.SceneLoader;
using UnityEngine;
using UnityEngine.UI;

namespace Totobono4.Game.UI {
    public class PauseTabUI : MonoBehaviour {
        [SerializeField] Button continueButton;
        [SerializeField] Button mainMenuButton;

        public EventHandler OnClean;

        protected virtual void Awake() {
            continueButton.onClick.AddListener(() => {
                Hide();
            });
            mainMenuButton.onClick.AddListener(() => {
                OnClean?.Invoke(this, EventArgs.Empty);
                SceneLoaderCore.Load(SceneLoaderCore.Scene.MainMenuScene);
            });
        }

        public virtual void Show() {
            gameObject.SetActive(true);
        }

        public virtual void Hide() {
            gameObject.SetActive(false);
        }

        public virtual void Clean() {
            Destroy(gameObject);
        }
    }
}