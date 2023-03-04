using Adams.SceneGraph;
using Adams.SceneGraphCore;

internal class Program
{
    private static void Main(string[] args)
    {
        ISceneNode root;
        root = new GroupNode("Root");
        IVisitor printGraph = new NameTypeVisitor();
        root.Accept(printGraph);
        ISceneNode node = new Cube("cube");
        (root as GroupNode).AddChild(node);
        node = new Cube("cube2");
        (root as GroupNode).AddChild(node);
        GroupNode snowman = new GroupNode("snowman");
        (root as GroupNode).AddChild(snowman);
        node = new Sphere("Bottom");
        snowman.AddChild(node);
        node = new Sphere("Middle");
        snowman.AddChild(node);
        node = new Sphere("Top");
        snowman.AddChild(node);
        root.Accept(printGraph);
    }
}