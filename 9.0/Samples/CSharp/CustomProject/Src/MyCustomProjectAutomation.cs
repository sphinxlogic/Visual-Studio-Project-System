﻿/// Copyright (c) Microsoft Corporation.  All rights reserved.

using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Project.Automation;

namespace Microsoft.VisualStudio.Project.Samples.CustomProject
{
	[ComVisible(true)]
	public class OAMyCustomProject : OAProject
	{
		#region Constructors
		/// <summary>
		/// Public constructor.
		/// </summary>
		/// <param name="project">Custom project.</param>
		public OAMyCustomProject(MyCustomProjectNode project)
			: base(project)
		{
		}
		#endregion
	}

	[ComVisible(true)]
	[Guid("D7EDB436-6F5A-4EF4-9E3F-67C15C2FA301")]
	public class OAMyCustomProjectFileItem : OAFileItem
	{
		#region Constructors
		/// <summary>
		/// Public constructor.
		/// </summary>
		/// <param name="project">Automation project.</param>
		/// <param name="node">Custom file node.</param>
		public OAMyCustomProjectFileItem(OAProject project, FileNode node)
			: base(project, node)
		{
		}
		#endregion
	}
}
