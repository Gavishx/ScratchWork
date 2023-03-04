namespace Adams.SceneGraphCore
{
    class Terrain : DrawableNodeBase
    {
        public Terrain(string name) : base(name)
        {

        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing terrain...");
        }
    }
}

