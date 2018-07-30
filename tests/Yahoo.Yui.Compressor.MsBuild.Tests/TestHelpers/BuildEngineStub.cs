﻿using Microsoft.Build.Framework;
using System.Collections;
using System.Collections.Generic;

namespace Yahoo.Yui.Compressor.MsBuild.Tests.TestHelpers
{
    public class BuildEngineStub : IBuildEngine
    {
        public BuildEngineStub()
        {
            Errors = new List<string>();
        }

        public List<string> Errors { get; private set; }

        #region IBuildEngine Members

        public void LogErrorEvent(BuildErrorEventArgs e)
        {
            Errors.Add(e.Message);
        }

        public void LogWarningEvent(BuildWarningEventArgs e)
        {
        }

        public void LogMessageEvent(BuildMessageEventArgs e)
        {
        }

        public void LogCustomEvent(CustomBuildEventArgs e)
        {
        }

        public bool BuildProjectFile(string projectFileName, string[] targetNames, IDictionary globalProperties,
                                     IDictionary targetOutputs)
        {
            return true;
        }

        public bool ContinueOnError
        {
            get { return true; }
        }

        public int LineNumberOfTaskNode
        {
            get { return 1; }
        }

        public int ColumnNumberOfTaskNode
        {
            get { return 1; }
        }

        public string ProjectFileOfTaskNode
        {
            get { return string.Empty; }
        }

        #endregion
    }
}