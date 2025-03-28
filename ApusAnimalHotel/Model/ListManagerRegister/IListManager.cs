
using System.Collections.Generic;
/// <summary>
///
///
/// Date: 2019-04-09
/// </summary>
namespace ApusAnimalHotel.Model.ListManagerRegister
    {
    /// <summary>
    /// Interface for implementation by manager classes hosting a collection
    /// of type List<T> where T can be any object type. In this documentation,
    /// the collection is refereed to as m_list.
    /// IListManager can be implemented by different classes passing any type <T> at
    /// deceleration but then T MUST HAVE THE SAME TYPE IN ALL METHODS INCLUDED IN THIS
    /// INTERFACE.  
    /// </summary>
    /// <typeparam name="T">Object type</typeparam>
    interface IListManager<T>
        {
        /// <summary>
        /// Return the number of items in the collection m_list
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        int Count { get; }

        /// <summary>
        /// Add an object to the collection m_list.
        /// </summary>
        /// <param name="aType">The aType.</param>
        /// <returns>True if successful otherwise false</returns>
        bool Add(T aType);
        /// <summary>
        /// Replace the object at a given position with another object.
        /// </summary>
        /// <param name="aType">Replacement object</param>
        /// <param name="anIndex">Position in the list</param>
        /// <returns>True if successful otherwise false.</returns>
        bool ChangeAt(T aType, int anIndex);
        /// <summary>
        /// Check that the index is in bounds.
        /// </summary>
        /// <param name="index">A position in the list.</param>
        /// <returns>True if with in bounds otherwise false.</returns>
        bool CheckIndex(int index);
        /// <summary>
        /// Delete all objects in the list.
        /// </summary>
        void DeleteAll();
        /// <summary>
        /// Remove an object from the collection m_list at
        /// a given position.
        /// </summary>
        /// <param name="anIndex">Index of object to be removed</param>
        /// <returns>True if successful otherwise false</returns>
        bool DeleteAt(int anIndex);
        /// <summary>
        /// Get object at a specific index.
        /// </summary>
        /// <param name="anIndex">Index in the list</param>
        /// <returns>Generic object</returns>
        T GetAt(int anIndex);
        /// <summary>
        /// Object information as a string.
        /// </summary>
        /// <returns>Array</returns>
        string[] ToStringArray();
        /// <summary>
        /// Object information as a string.
        /// </summary>
        /// <returns>String List</returns>
        List<string> ToSrtingList();

        //Assignment 4
        void BinarySerialize(string fileName);
        void BinaryDeSerialize(string fileName);
        void XMLSerialize(string fileName);
        }
    }
