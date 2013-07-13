using System;

namespace MrByte.Utility
{
    public static class WeakReferenceExtension
    {
        public static T GetTarget<T>(this WeakReference<T> reference)
            where T : class
        {
            T target;

            if (reference.TryGetTarget(out target))
            {
                return target;
            }

            return null;
        }
    }
}
