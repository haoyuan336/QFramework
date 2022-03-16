/****************************************************************************
 * Copyright (c) 2015 - 2022 liangxiegame UNDER MIT License
 * 
 * http://qframework.io
 * https://github.com/liangxiegame/QFramework
 ****************************************************************************/

using System;

namespace QFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ClassAPIAttribute : Attribute
    {
        public string GroupName { get; private set; }

        public ClassAPIAttribute(string groupName)
        {
            GroupName = groupName;
        }
    }
}