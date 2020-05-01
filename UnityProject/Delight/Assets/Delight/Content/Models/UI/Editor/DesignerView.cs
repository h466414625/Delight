// Internal view logic generated from "EditorMainView.xml"
#region Using Statements
using Delight.Editor.Parser;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    /// <summary>
    /// Contains information about a view in the designer.
    /// </summary>
    public class DesignerView: BindableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _viewTypeName;
        public string ViewTypeName
        {
            get { return _viewTypeName; }
            set { SetProperty(ref _viewTypeName, value); }
        }

        private bool _isDirty;
        public bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                SetProperty(ref _isDirty, value);
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        private bool _isNew;
        public bool IsNew
        {
            get { return _isNew; }
            set
            {
                SetProperty(ref _isNew, value);
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        private bool _isRuntimeParsed;
        public bool IsRuntimeParsed
        {
            get { return _isRuntimeParsed; }
            set
            {
                SetProperty(ref _isRuntimeParsed, value);
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { SetProperty(ref _filePath, value); }
        }

        public string DisplayName
        {
            get
            {
                return IsDirty ? Name + "*" : Name;
            }
        }

        public ViewObject ViewObject { get; set; }
        public string XmlText { get; internal set; }
    }

    /// <summary>
    /// Designer view collection.
    /// </summary>
    public class DesignerViewData : BindableCollection<DesignerView>
    {
    }
}
