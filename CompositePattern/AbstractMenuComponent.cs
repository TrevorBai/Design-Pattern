using System;

namespace CompositePattern
{
    public abstract class AbstractMenuComponent
    {
        public virtual void Add(AbstractMenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(AbstractMenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual AbstractMenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
