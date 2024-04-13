using System.Collections.Generic;

namespace PLAYGROUND
{
    public class Scene
    {
        public List<Mesh> Models { get; set; }

        public Scene()
        {
            Models = new List<Mesh>();
        }

        public void AddModel(Mesh model)
        {
            Models.Add(model);
        }

    }
}
