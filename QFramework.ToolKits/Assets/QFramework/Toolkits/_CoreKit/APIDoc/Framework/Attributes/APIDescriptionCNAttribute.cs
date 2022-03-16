/****************************************************************************
 * Copyright (c) 2015 - 2022 liangxiegame UNDER MIT License
 * 
 * http://qframework.io
 * https://github.com/liangxiegame/QFramework
 ****************************************************************************/

using System;

namespace QFramework
{
    public class APIDescriptionCNAttribute : Attribute
    {
        public string Description { get; private set; }

        public APIDescriptionCNAttribute(string description)
        {
            Description = description;
        }
    }
}