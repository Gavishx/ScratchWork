namespace Adams.SceneGraphCore
{
    class Sphere : DrawableNodeBase
    {
        public Sphere(string name) : base(name)
        {

        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing a Sphere...");
        }
    }
}

