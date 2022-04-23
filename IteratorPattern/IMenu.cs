using System.Collections.Generic;

namespace IteratorPattern
{
    public interface IMenu
    {
        IEnumerator<MenuItem> CreateEnumerator();
    }
}
