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

namespace MTC
{
    /// <summary>
    /// Managed Tab Control tab page object (normal tab page)
    /// </summary>
    public class MTCTabPage : IMTCTabPage
    {
        /// <summary>
        /// Managed Tab Control tab page object (normal tab page)
        /// </summary>
        public MTCTabPage() : base() { }
        /// <summary>
        /// Managed Tab Control tab page object (normal tab page)
        /// </summary>
        /// <param name="text">The text that appeared on the control.</param>
        /// <param name="id">The id of this page.</param>
        public MTCTabPage(string text, string id) : base(text, id) { }
    }
}
