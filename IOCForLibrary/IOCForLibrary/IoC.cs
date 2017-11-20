using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IOCForLibrary
{
    public class IoC
    {
        private static readonly IDictionary<Type, Type> attachedTypes = new Dictionary<Type, Type>();
        private static readonly IDictionary<Type, object> attachedTypeInstances = new Dictionary<Type, object>();
        private static readonly List<Type> listOfSingltons = new List<Type>();
        private static object syncRoot = new Object();

        public static void Register<TContract, TImplementation>()
        {
            if ((attachedTypeInstances.ContainsKey(typeof(TContract))) &&(attachedTypeInstances[typeof(TContract)].ToString()!=typeof(TImplementation).ToString()))
            {
                attachedTypeInstances.Remove(typeof(TContract));
            }
            attachedTypes[typeof(TContract)] = typeof(TImplementation);
        }

        public static void RegisterSingleton<TContract, TImplementation>()
        {
            if ((attachedTypeInstances.ContainsKey(typeof(TContract))) && (attachedTypeInstances[typeof(TContract)] != null))
            {
                listOfSingltons.Add(typeof(TImplementation));
            }
            Register<TContract, TImplementation>();
        }

        public static void Register<TContract, TImplementation>(TImplementation instance)
        {
            attachedTypeInstances[typeof(TContract)] = instance;
        }

        public static T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private static object Resolve(Type contract)
        {
            if (attachedTypeInstances.ContainsKey(contract))
            { 
                return attachedTypeInstances[contract];
            }
            else
            {
                object objectForImplementation = null;
                Type implementationType;

                if (attachedTypes.ContainsKey(contract))
                {
                    implementationType = attachedTypes[contract];
                }
                else
                    return objectForImplementation;

                ConstructorInfo constructor = implementationType.GetConstructors()[0];
                ParameterInfo[] constructorParameters = constructor.GetParameters();

                if (constructorParameters.Length == 0)
                {
                    objectForImplementation =  Activator.CreateInstance(implementationType);

                    return SetProperties(implementationType, objectForImplementation);
                }

                List<object> parameters = new List<object>(constructorParameters.Length);
                foreach (ParameterInfo parameterInfo in constructorParameters)
                {
                    parameters.Add(Resolve(parameterInfo.ParameterType));
                }

                objectForImplementation = constructor.Invoke(parameters.ToArray());
                objectForImplementation = SetProperties(implementationType, objectForImplementation);

                if(listOfSingltons.Contains(implementationType))
                    attachedTypeInstances[contract] = objectForImplementation;

                return SetProperties(implementationType, objectForImplementation);
            }
        }
        
        private static object SetProperties(Type implementationType, object objectToSetProperties)
        {
            PropertyInfo[] propert = implementationType.GetProperties();
            foreach (PropertyInfo property in propert)
            {
                if(attachedTypes.ContainsKey(property.PropertyType))
                    property.SetValue(objectToSetProperties, Resolve(property.PropertyType));
            }
            return objectToSetProperties;
        }
    }
}
