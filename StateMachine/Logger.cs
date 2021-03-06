//
// Logger.cs
//
// Author:
//       Jean-Pierre Bouchard <>
//
// Copyright (c) 2015 Jean-Pierre Bouchard
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
//------------------------------------------------------------------------------
using System;
namespace DGX
{
    public class Logger
    {
        private bool mIsDebug = false;
        private string mObjectName;
        
        public Logger (string sObjectName)
        {
            mObjectName = sObjectName;
        }
        public void log(string s)
        {
            if (DEBUG) {
                Console.WriteLine(mObjectName + " => " + s);
            }
        }
        public void logTag(string tag, string message)
        {
            log (tag + ": " + message);
        }
        public void logTag(string tag, int value)
        {
            log (tag + ": " + value.ToString());
        }
        public void logTag(string tag, float value)
        {
            log (tag + ": " + value.ToString());
        }
        public string OBJECT_NAME
        {
            get {return mObjectName;}
            set{ mObjectName = value;}
        }
        public bool DEBUG
        {
            get {return mIsDebug;}
            set{ mIsDebug = value;}
        }
    }
}

