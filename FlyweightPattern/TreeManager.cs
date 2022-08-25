using System.Collections.Generic;

namespace FlyweightPattern
{
    // An optimization pattern
    public class TreeManager
    {
        // 2D array
        private readonly List<List<Tree>> _treeList;
        private double _x;
        private double _y;
        private double _age;

        public void DisplayTrees()
        {
            foreach (var treeRow in _treeList)
            {
                // Get array row
                foreach (var tree in treeRow)
                {
                    tree.Display(tree.X, tree.Y, tree.Age);
                }
            }
        }

        public void SetXCoord(double xCoord)
        {
            _x = xCoord;
        }

        public void SetYCoord(double yCoord)
        {
            _y = yCoord;
        }

        public void SetAge(double age)
        {
            _age = age;
        }
    }
}
