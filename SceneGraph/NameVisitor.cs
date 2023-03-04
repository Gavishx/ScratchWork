using Adams.SceneGraph;
namespace Adams.SceneGraphCore
{
    public class NameVisitor : IVisitor
    {
        public NameVisitor()
        {
        }

        public string Name => throw new NotImplementedException();

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void PostVisit(IDrawableNode drawable)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(ITransformNode transform)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(IStateNode state)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(IGroupNode group)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PreVisit(IDrawableNode drawable)
        {
            System.Console.WriteLine(currentIndentation
                + "Drawable name: " + drawable.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(ITransformNode transform)
        {
            System.Console.WriteLine(currentIndentation
                + "Transform name: " + transform.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IStateNode state)
        {
            System.Console.WriteLine(currentIndentation
                + "State name: " + state.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IGroupNode group)
        {
            System.Console.WriteLine(currentIndentation
                + "Group name: " + group.Name);
            currentIndentation += indentIncrement;
        }

        #region Member Variables 
        string currentIndentation = "";
        string indentIncrement = "  ";
        #endregion
    }
}

