using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class MenuComponent
    {
        public virtual void Add(MenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual string Name { get; }

        public virtual string Description { get; }

        public virtual bool Vegeterian { get; }

        public virtual double Price { get; }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }
}
