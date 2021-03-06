// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using OLEDB.Test.ModuleCore;

namespace System.Xml.Tests
{
    internal class XmlBaseCharConvertTests1 : XmlBaseCharConvertTests
    {
        #region Constructors and Destructors

        public XmlBaseCharConvertTests1()
        {
            for (int i = 0; i < _byte_BaseChar.Length; i = i + 2)
            {
                AddVariation(new CVariation(this, "EncodeName-EncodeLocalName : " + _Expbyte_BaseChar[i / 2], XmlEncodeName4));
            }
        }

        #endregion

        #region Public Methods and Operators

        public int XmlEncodeName4()
        {
            int i = ((CurVariation.id) - 1) * 2;
            string strEnVal = string.Empty;

            strEnVal = XmlConvert.EncodeName((BitConverter.ToChar(_byte_BaseChar, i)).ToString());
            CError.Compare(strEnVal, _Expbyte_BaseChar[i / 2], "Comparison failed at " + i);
            return TEST_PASS;
        }
        #endregion
    }
}
