using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libTestBindingSDK.a", LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]