using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.GameManager;

namespace TextGame.Scene
{
    public abstract class Scene
    {
        protected SceneManager sceneManager;
        public Scene(SceneManager sceneManager)
        {
            this.sceneManager = sceneManager;
        }
        public abstract void Render();
        public abstract void Update();
    }
}
