using System.Collections.Generic;

namespace PLAYGROUND
{
    public class Scene
    {
        public List<Model> Models { get; set; } = new List<Model>();

        public void AddModel(Model model)
        {
            Models.Add(model);
        }

        public void RemoveModel(Model model)
        {
            Models.Remove(model);
        }
    }
}