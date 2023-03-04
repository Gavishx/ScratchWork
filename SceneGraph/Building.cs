using Adams.SceneGraph;
namespace adams.SceneGraphCore
{
	class Building : DrawableNodeBase
	{
        public Building(string name) : base(name)
        {

        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing a building...");

        }
    }
}

