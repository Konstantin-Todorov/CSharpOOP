﻿namespace HTMLRenderer
{
    using System.Collections.Generic;

    public interface IElement : IBaseElement
    {
        string TextContent { get; set; }
        IEnumerable<IBaseElement> ChildElements { get; }
        void AddElement(IElement element);
    }
}
