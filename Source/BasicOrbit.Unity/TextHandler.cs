﻿#region License
/*
 * Basic Orbit
 * 
 * TextHandler - Script for marking Text components to replace and to handle text field updates
 * 
 * Copyright (C) 2016 DMagic
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
 * 
 * 
 */
#endregion

using UnityEngine;
using UnityEngine.Events;

namespace BasicOrbit.Unity
{
	/// <summary>
	/// A simple script that both marks Text UI elements to be replaced
	/// and handles updating the text field for the Text Mesh Pro replacement element
	/// </summary>
	public class TextHandler : MonoBehaviour
    {
        [SerializeField]
        private bool m_ReadoutLabel = false;
        [SerializeField]
        private bool m_ReadoutField = false;

        public class OnTextEvent : UnityEvent<string> { }

		private OnTextEvent _onTextUpdate = new OnTextEvent();

        public bool ReadoutLabel
        {
            get { return m_ReadoutLabel; }
        }

        public bool ReadoutField
        {
            get { return m_ReadoutField; }
        }
        
        public UnityEvent<string> OnTextUpdate
		{
			get { return _onTextUpdate; }
		}
	}
}