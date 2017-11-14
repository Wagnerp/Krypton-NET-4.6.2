﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel; 
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Navigator;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for events that need a page and context menu.
	/// </summary>
	public class ContextPageEventArgs : CancelEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ContextPageEventArgs class.
		/// </summary>
        /// <param name="page">Page associated with the context menu.</param>
        /// <param name="contextMenu">Context menu that can be customized.</param>
        /// <param name="cancel">Initial value for the cancel property.</param>
        public ContextPageEventArgs(KryptonPage page, 
                                    KryptonContextMenu contextMenu,
                                    bool cancel)
            : base(cancel)
		{
            Page = page;
            KryptonContextMenu = contextMenu;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets access to page associated with the context menu.
        /// </summary>
        public KryptonPage Page { get; }

	    /// <summary>
        /// Gets access to context menu that can be customized.
        /// </summary>
        public KryptonContextMenu KryptonContextMenu { get; }

	    #endregion
	}
}