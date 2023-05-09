using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TextGame.Scene;

namespace TextGame.GameManager
{
    public class SceneManager
    {
        protected GameManager gameManager;
        public GameManager GameManager { get { return gameManager; } }
        private Dictionary<string, Scene.Scene> sceneDictionary = new Dictionary<string, Scene.Scene>();
        private Scene.Scene currentScene;
        public Scene.Scene CurrentScene { get { return currentScene; } }
        public SceneManager(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }
        public void Init()
        {
            sceneDictionary.Add("Invasion", new InvasionScene(this));
            sceneDictionary.Add("MainMenu", new MainMenuScene(this));
            sceneDictionary.Add("TacticalMap", new TacticalMapScene(this));
            GotoMainMenuScene();
        }
        public void GotoMainMenuScene()
        {
            sceneDictionary.TryGetValue("MainMenu", out currentScene);
        }
        public void GotoInvasionScene()
        {
            Console.WriteLine(currentScene);
            sceneDictionary.TryGetValue("Invasion", out currentScene);
            Console.WriteLine(currentScene);
        }
        public void GotoTacticalMapScene()
        {
            sceneDictionary.TryGetValue("TacticalMap", out currentScene);
        }
    }
}
