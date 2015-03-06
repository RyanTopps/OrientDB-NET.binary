﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Orient.Client.Mapping
{
    internal class LongFieldMapping<TTarget> : BasicNamedFieldMapping<TTarget>
    {
        public LongFieldMapping(PropertyInfo propertyInfo, string fieldPath)
            : base(propertyInfo, fieldPath)
        {

        }
<<<<<<< HEAD

        protected override void MapToNamedField(ODocument document, TTarget typedObject)
        {
=======
        protected override void MapToNamedField(ODocument document, TTarget typedObject)
        {
            // Only until bug #3483 will be fixed than use decimal
>>>>>>> 49f1bc93f51639abe0c0337a2fea45d8adfcc513
            object item = document.GetField<object>(_fieldPath);
            if (item is IConvertible)
                SetPropertyValue(typedObject, Convert.ChangeType(item, typeof(long)));
        }

    }
}