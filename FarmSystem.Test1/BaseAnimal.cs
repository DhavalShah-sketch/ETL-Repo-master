using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FarmSystem.Test1.Interfaces;

namespace FarmSystem.Test1
{
    public abstract class BaseAnimal : IAnimal
    {
        const string mustBeImplementedInConcreteClass = "\"{0}\" class must implement method \"{1}\" before using it.";
        private string id;
        private int noOfLegs;

        protected BaseAnimal()
        {
            id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Use this ONLY WHEN there is a variance from default Number of Legs for an animal instance.
        /// </summary>
        /// <param name="NoOfLegs"></param>
        public BaseAnimal(int NoOfLegs): this() // in case one or more leg(s) are amputated/ variance from default value
        {
            NumberOfLegs = NoOfLegs;
        }
        public string Id
        {
            get { return id; }
            private set { id = value; }
        }
        public int NumberOfLegs
        {
            get { return noOfLegs; }
            set { noOfLegs = value > 0 ? value : 
                    throw new ArgumentOutOfRangeException("Number of legs must be > 0"); // should they? not sure.
            }
        }

        public virtual void Walk()
        {
            var method = MethodBase.GetCurrentMethod().Name;
            throw new NotImplementedException(string.Format(mustBeImplementedInConcreteClass, this.GetType().Name, method));
        }
        public virtual void Talk()
        {
            var method = MethodBase.GetCurrentMethod().Name;
            throw new NotImplementedException(string.Format(mustBeImplementedInConcreteClass, this.GetType().Name, method));
        }

        public virtual void Run()
        {
            var method = MethodBase.GetCurrentMethod().Name;
            throw new NotImplementedException(string.Format(mustBeImplementedInConcreteClass, this.GetType().Name, method));
        }

        public virtual void ProduceMilk()
        {
            var method = MethodBase.GetCurrentMethod().Name;
            throw new NotImplementedException(string.Format(mustBeImplementedInConcreteClass, this.GetType().Name, method));
        }

    }
}
