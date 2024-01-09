using System;
using System.Reflection;

namespace BasicFacebookFeatures
{
    public static class Singleton<T>
        where T : class
    {
        private static readonly object sr_LockCreationNewInstance = new object();
        private static T s_Instance = null;

        static Singleton()
        {
        }

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockCreationNewInstance)
                    {
                        if (s_Instance == null)
                        {
                            Type typeOfT = typeof(T);
                            ConstructorInfo constructor = null;

                            // Exclude static and public constructors
                            constructor = typeOfT.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);

                            // Exclude internal and protected constructors
                            if (constructor == null || constructor.IsAssembly || constructor.IsFamily)
                            {
                                throw new Exception(string.Format("A private constructor is missing for '{0}'.", typeof(T).Name));
                            }

                            s_Instance = constructor.Invoke(null) as T;
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}