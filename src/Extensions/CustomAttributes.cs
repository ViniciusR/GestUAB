//
// CustomAttributes.cs
//
// Author:
//       Tony Alexander Hild <tony_hild@yahoo.com>
//
// Copyright (c) 2012 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

namespace GestUAB
{

    public enum ScaffoldVisibilityType
    {
//        Create,
//        Read,
//        Update,
//        Delete,
//        All = Create | Read | Update | Delete,
//        AllHidden = All | Hidden,
        Hidden,
        Show,
        None
    }

    public class ScaffoldVisibilityAttribute : Attribute
    {
        public ScaffoldVisibilityType All { get; private set; }

        public ScaffoldVisibilityType Create { get; private set; }

        public ScaffoldVisibilityType Read { get; private set; }

        public ScaffoldVisibilityType Update { get; private set; }

        public ScaffoldVisibilityType Delete { get; private set; }

        public ScaffoldVisibilityAttribute (ScaffoldVisibilityType create = ScaffoldVisibilityType.None, 
                                            ScaffoldVisibilityType read = ScaffoldVisibilityType.None,
                                            ScaffoldVisibilityType update = ScaffoldVisibilityType.None,
                                            ScaffoldVisibilityType delete = ScaffoldVisibilityType.None,
                                            ScaffoldVisibilityType all = ScaffoldVisibilityType.None)
        {
            if (all != ScaffoldVisibilityType.None) {
                Create = all;
                Read = all;
                Update = all;
                Delete = all;
            } else {
                Create = create;
                Read = read;
                Update = update;
                Delete = delete;
            }
            All = all;
        }
    }
}

