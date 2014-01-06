﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using EnvDTE;
using Microsoft.CSS.Core;
using Microsoft.VisualStudio.Utilities;

namespace MadsKristensen.EditorExtensions
{
    // TODO: Remove this when the SASS editor is included in VS.
    [Export(typeof(ICssErrorFilter))]
    [Name("SassErrorFilter")]
    [Order(After = "Default")]
    internal class SassErrorFilter : ICssErrorFilter
    {
        public void FilterErrorList(IList<ICssError> errors, ICssCheckerContext context)
        {
            ProjectItem item = ProjectHelpers.GetActiveFile();
            if (item == null || !item.FileNames[0].EndsWith(".scss", StringComparison.OrdinalIgnoreCase))
                return;

            errors.Clear();
        }
    }
}