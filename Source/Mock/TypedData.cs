using System;
using System.Collections.Generic;

namespace LeanTest.Mock
{
    /// <summary>
    /// Use this as a base class for classes which implement <c>IMockForData</c> type <c>T</c>.
    /// </summary>
    public class TypedData<T>
    {
        /// <summary>
        /// Stores data for type <c>T</c>.
        /// </summary>
        protected List<T> Data { get; } = new List<T>();

        /// <summary>
        /// Store data of type <c>T</c>.
        /// </summary>
        public void WithData(T data)
        {
            Data.Add(data);
        }

        /// <summary>
        /// Clear all stored data.
        /// </summary>
        public virtual void Clear(Type type)
        {
            if (type != typeof(T)) throw new ArgumentException(nameof(type));
            Data.Clear();
        }

        /// <summary>
        /// Override this in order to execute build actions.
        /// </summary>
        public virtual void Build()
        {
        }
    }
}