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
using System;
using System.Windows.Forms;
namespace MTC
{
    /// <summary>
    /// Managed Tab Control tab page interface
    /// </summary>
    public abstract class IMTCTabPage
    {
        /// <summary>
        /// Managed Tab Control Page
        /// </summary>
        public IMTCTabPage()
        {
            this.text = "";
            this.id = "";
            this.imageIndex = 0;
        }
        /// <summary>
        /// Managed Tab Control Page
        /// </summary>
        /// <param name="text">The text that appeared on the control.</param>
        /// <param name="id">The id of this page.</param>
        public IMTCTabPage(string text, string id)
        {
            this.text = text;
            this.id = id;
            this.imageIndex = 0;
        }
        /// <summary>
        /// Managed Tab Control Page
        /// </summary>
        /// <param name="text">The text that appeared on the control.</param>
        /// <param name="id">The id of this page.</param>
        /// <param name="imageIndex">The image index of this tap page.</param>
        public IMTCTabPage(string text, string id, int imageIndex)
        {
            this.text = text;
            this.id = id;
            this.imageIndex = imageIndex;
        }
        /// <summary>
        /// The text of this page
        /// </summary>
        protected string text = "";
        /// <summary>
        /// The id of this page
        /// </summary>
        protected string id = "";
        /// <summary>
        /// The panel control
        /// </summary>
        protected Panel panel;
        /// <summary>
        /// The image index
        /// </summary>
        protected int imageIndex;
        /// <summary>
        /// The draw type
        /// </summary>
        protected MTCTabPageDrawType drawType = MTCTabPageDrawType.Text;

        /// <summary>
        /// Get or set the text that appeared on the control
        /// </summary>
        public virtual string Text
        {
            get { return text; }
            set { text = value; }
        }
        /// <summary>
        /// Get or set the id of this page.
        /// </summary>
        public virtual string ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Get or set the image index of this tap page.
        /// </summary>
        public virtual int ImageIndex
        { get { return imageIndex; } set { imageIndex = value; } }
        /// <summary>
        /// Get or set the Panel control, you should use this panel to add controls to this tab.
        /// </summary>
        public virtual Panel Panel
        { get { return panel; } set { panel = value; } }
        /// <summary>
        /// Get or set how this page should be drawn.
        /// </summary>
        public virtual MTCTabPageDrawType DrawType
        { get { return drawType; } set { drawType = value; } }
    }
}
