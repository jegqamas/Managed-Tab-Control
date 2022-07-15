﻿/* This file is part of MTC "Managed Tab Control" project.
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
namespace MTC
{
    /// <summary>
    /// The Managed Tab Page Draw Mode. This can be used for tap pages only.
    /// </summary>
    public enum MTCTabPageDrawType
    {
        /// <summary>
        /// The tab page shows text only.
        /// </summary>
        Text,
        /// <summary>
        /// The tab page shows image only.
        /// </summary>
        Image,
        /// <summary>
        /// The tab page show text and image.
        /// </summary>
        TextAndImage
    }
}
