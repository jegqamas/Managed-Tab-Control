/* This file is part of MTC "Managed Tab Control" project.
 * MTC (Managed Tab Control) is an advanced tab control written 
 * in .net framework.
 * 
 * Copyright © Ala Ibrahim Hadid 2013
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;

namespace MTC
{
    /// <summary>
    /// The Managed Tab Control Tab Pages Collection. Should be used only with Managed Tab Control controls.
    /// </summary>
    public class MTCTabPagesCollection
    {
        /// <summary>
        /// The Managed Tab Control Tab Pages Collection. Should be used only with Managed Tab Control controls.
        /// </summary>
        /// <param name="owner">The <see cref="ManagedTabControlPanel"/>, the parent of this collection.</param>
        public MTCTabPagesCollection(ManagedTabControlPanel owner)
        {
            this.owner = owner;
        }

        private ManagedTabControlPanel owner;

        private List<IMTCTabPage> list = new List<IMTCTabPage>();
        /// <summary>
        /// Get an index for item
        /// </summary>
        /// <param name="item">The <see cref="IMTCTabPage"/></param>
        /// <returns>The index of that tab page if found otherwise -1</returns>
        public int IndexOf(IMTCTabPage item)
        {
            return list.IndexOf(item);
        }
        /// <summary>
        /// Insert an item to the collection
        /// </summary>
        /// <param name="index">The index where to insert</param>
        /// <param name="item">The item to insert</param>
        public void Insert(int index, IMTCTabPage item)
        {
            list.Insert(index, item);
            owner.OnTabPagesItemAdded();
        }
        /// <summary>
        /// Remove item at index
        /// </summary>
        /// <param name="index">The index to remove at</param>
        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
            owner.OnTabPagesItemRemoved();
            if (list.Count == 0)
                owner.OnTabPagesCollectionClear();
        }
        /// <summary>
        /// The Managed Tab Control Tab Pages Collection. Should be used only with Managed Tab Control controls.
        /// </summary>
        /// <param name="index">The item index</param>
        /// <returns>Item at index if found otherwise null</returns>
        public IMTCTabPage this[int index]
        {
            get
            {
                if (index < list.Count && index >= 0)
                    return list[index];
                return null;
            }
            set
            {
                if (index < list.Count && index >= 0)
                    list[index] = value;
            }
        }
        /// <summary>
        /// Add item to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add(IMTCTabPage item)
        {
            list.Add(item);
            owner.OnTabPagesItemAdded();
        }
        /// <summary>
        /// Clear the collection
        /// </summary>
        public void Clear()
        {
            list.Clear();
            owner.OnTabPagesCollectionClear();
        }
        /// <summary>
        /// Get if item is in the collection
        /// </summary>
        /// <param name="item">The item</param>
        /// <returns>True if item found otherwise false</returns>
        public bool Contains(IMTCTabPage item)
        {
            return list.Contains(item);
        }
        /// <summary>
        /// Copy the collection to another
        /// </summary>
        /// <param name="array">The array to copy into</param>
        /// <param name="arrayIndex">The index within the array to start with</param>
        public void CopyTo(IMTCTabPage[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }
        /// <summary>
        /// Get the collection count
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }
        /// <summary>
        /// Remove item from the collection
        /// </summary>
        /// <param name="item">The item to remove</param>
        public void Remove(IMTCTabPage item)
        {
            list.Remove(item);
            owner.OnTabPagesItemRemoved();
            if (list.Count == 0)
                owner.OnTabPagesCollectionClear();
        }
        /// <summary>
        /// Get Enumerator
        /// </summary>
        /// <returns>Enumerator</returns>
        public IEnumerator<IMTCTabPage> GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
