using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.GameManager
{
    public class GameManager
    {
        private SceneManager sceneManager;
        private bool isGameOngoing;
        int i = 1;
        public void Run()
        {
            Init();
            while (isGameOngoing)
            {
                Render();
                Update();               
            }
        }
        private void Init()
        {           
            isGameOngoing = true;
            sceneManager = new SceneManager(this);
            DataManager.Init();
            sceneManager.Init();
        }
        private void Render()
        {
            Console.Clear();
            sceneManager.CurrentScene.Render();
        }
        private void Update()
        {
            sceneManager.CurrentScene.Update();
        }
        public void FinishGame()
        {
            isGameOngoing = false;
        }
    }
}

