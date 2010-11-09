using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Buttercup.Control.Resources;

namespace Buttercup.Control
{
    public class LocalizedStrings
    {
        public LocalizedStrings()
        {
            
        }

        private static readonly Strings stringLibrary = new Strings();
        public Strings StringLibrary { get { return stringLibrary; } }
    }
}
