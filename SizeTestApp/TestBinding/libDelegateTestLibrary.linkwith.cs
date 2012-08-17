using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libDelegateTestLibrary.a", LinkTarget.Simulator, ForceLoad = true)]
