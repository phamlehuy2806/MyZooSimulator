using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooSimulator
{
    public abstract class Animal : Specis
    {
        public override void Breed(Environment ev)
        {
            throw new NotImplementedException();
        }
    }
}
