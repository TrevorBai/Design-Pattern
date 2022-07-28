using System.Collections.Generic;
using System.Dynamic;

namespace DynamicProxy
{
    public class OwnerInvocationHandler : DynamicObject
    {
        private readonly IPerson _person;

        // The inner dictionary.
        Dictionary<string, object> dictionary = new Dictionary<string, object>();

        // Getting a property.
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return dictionary.TryGetValue(binder.Name, out result);
        }

        // Setting a property.
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (binder.Name.Equals("Rating")) return false;
            dictionary[binder.Name] = value;
            return true;
        }

        public OwnerInvocationHandler(IPerson person)
        {
            _person = person;
            dictionary["Name"] = person.GetName();
            dictionary["Gender"] = person.GetGender();
            dictionary["Interests"] = person.GetInterests();
            dictionary["Rating"] = person.GetGeekRating();
        }

        // Calling a method.
        //public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        //{
        //    try
        //    {
        //        // Do stuff here
        //        if (binder.Name.StartsWith("Get"))
        //        {
        //            // Call _person object
        //            result = _person.GetType().GetMethod(binder.Name).Invoke(_person, args);
        //            return true;
        //        } else if (binder.Name.Equals("SetGeekRating"))
        //        {
        //            throw new AccessViolationException();
        //        } else if (binder.Name.StartsWith("Set"))
        //        {
        //            // Call _person object
        //            result = _person.GetType().GetMethod(binder.Name).Invoke(_person, args);
        //            return true;
        //        }
        //        throw new NotSupportedException();
        //    } catch
        //    {
        //        result = null;
        //        return false;
        //    }
        //}

        public string GetName()
        {
            return (string)dictionary["Name"];
        }

        public int GetGeekRating()
        {
            return (int)dictionary["Rating"];
        }
    }
}
