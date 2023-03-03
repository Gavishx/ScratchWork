namespace adams.SceneGraph
{
	public interface ISceneNode
	{
		void Accept(IVisitor visitor);
		string Name { get; }
	}
}

