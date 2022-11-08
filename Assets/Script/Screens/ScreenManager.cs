using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Screens
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screens;

        public ScreenType startScreen = ScreenType.MainMenu;

        private ScreenBase _currentScreen;

        
        protected override void Awake()
        {
            base.Awake();
            HideAll();
        }

        private void Start()
        {
            ShowByType(startScreen);
        }

        public void ShowByType(ScreenType type)
        {

            if (_currentScreen != null)
                _currentScreen.Hide();

            var nextScreen = screens.Find(i => i.screenType == type);

            nextScreen.Show();
            _currentScreen = nextScreen;
        }

        public void HideAll()
        {
            screens.ForEach(i => i.Hide());
        }
    }
}