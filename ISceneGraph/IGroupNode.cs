using Adams.SceneGraph;
using System.Collections.Generic;

namespace Adams.SceneGraph
{
	public interface IGroupNode : ISceneNode
	{
        void AddChild(ISceneNode child);
    }
}
