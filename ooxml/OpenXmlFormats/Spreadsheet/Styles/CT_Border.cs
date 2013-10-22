﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
    public enum ST_BorderStyle
    {
        none,
        thin,
        medium,
        dashed,
        dotted,
        thick,
        @double,
        hair,
        mediumDashed,
        dashDot,
        mediumDashDot,
        dashDotDot,
        mediumDashDotDot,
        slantDashDot,
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_Border
    {

        private CT_BorderPr leftField;

        private CT_BorderPr rightField;

        private CT_BorderPr topField;

        private CT_BorderPr bottomField;

        private CT_BorderPr diagonalField;

        private CT_BorderPr verticalField;

        private CT_BorderPr horizontalField;

        private bool diagonalUpField;

        private bool diagonalUpFieldSpecified;

        private bool diagonalDownField;

        private bool diagonalDownFieldSpecified;

        private bool outlineField;

        public CT_Border()
        {

        }
        public CT_Border Copy()
        {
            CT_Border obj = new CT_Border();
            obj.bottomField = this.bottomField;
            obj.topField = this.topField;
            obj.rightField = this.rightField;
            obj.leftField = this.leftField;
            obj.horizontalField = this.horizontalField;
            obj.verticalField = this.verticalField;
            obj.outlineField = this.outlineField;
            return obj;
        }
        public CT_BorderPr AddNewDiagonal()
        {
            if (this.diagonalField == null)
                this.diagonalField = new CT_BorderPr();
            return this.diagonalField;
        }
        public bool IsSetDiagonal()
        {
            return this.diagonalField != null;
        }
        public void unsetDiagonal()
        {
            this.diagonalField = null;
        }

        public void unsetRight()
        {
            this.rightField = null;
        }
        public void unsetLeft()
        {
            this.leftField = null;
        }
        public void unsetTop()
        {
            this.topField = null;
        }
        public void unsetBottom()
        {
            this.bottomField = null;
        }
        public bool IsSetBottom()
        {
            return this.bottomField != null;
        }
        public bool IsSetLeft()
        {
            return this.leftField != null;
        }
        public bool IsSetRight()
        {
            return this.rightField != null;
        }
        public bool IsSetTop()
        {
            return this.topField != null;
        }

        public bool IsSetBorder()
        {
            return this.leftField != null || this.rightField != null
                || this.topField != null || this.bottomField != null;
        }
        public CT_BorderPr AddNewTop()
        {
            if (this.topField == null)
                this.topField = new CT_BorderPr();
            return this.topField;
        }
        public CT_BorderPr AddNewRight()
        {
            if (this.rightField == null)
                this.rightField = new CT_BorderPr();
            return this.rightField;
        }
        public CT_BorderPr AddNewLeft()
        {
            if (this.leftField == null)
                this.leftField = new CT_BorderPr();
            return this.leftField;
        }
        public CT_BorderPr AddNewBottom()
        {
            if (this.bottomField == null)
                this.bottomField = new CT_BorderPr();
            return this.bottomField;
        }

        [XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
        public CT_BorderPr left
        {
            get
            {
                return this.leftField;
            }
            set
            {
                this.leftField = value;
            }
        }
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
        public CT_BorderPr right
        {
            get
            {
                return this.rightField;
            }
            set
            {
                this.rightField = value;
            }
        }
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
        public CT_BorderPr top
        {
            get
            {
                return this.topField;
            }
            set
            {
                this.topField = value;
            }
        }
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
        public CT_BorderPr bottom
        {
            get
            {
                return this.bottomField;
            }
            set
            {
                this.bottomField = value;
            }
        }
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
        public CT_BorderPr diagonal
        {
            get
            {
                return this.diagonalField;
            }
            set
            {
                this.diagonalField = value;
            }
        }
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
        public CT_BorderPr vertical
        {
            get
            {
                return this.verticalField;
            }
            set
            {
                this.verticalField = value;
            }
        }
        [XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
        public CT_BorderPr horizontal
        {
            get
            {
                return this.horizontalField;
            }
            set
            {
                this.horizontalField = value;
            }
        }
        [XmlAttribute]
        public bool diagonalUp
        {
            get
            {
                return this.diagonalUpField;
            }
            set
            {
                this.diagonalUpField = value;
            }
        }

        [XmlIgnore]
        public bool diagonalUpSpecified
        {
            get
            {
                return this.diagonalUpFieldSpecified;
            }
            set
            {
                this.diagonalUpFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public bool diagonalDown
        {
            get
            {
                return this.diagonalDownField;
            }
            set
            {
                this.diagonalDownField = value;
            }
        }

        [XmlIgnore]
        public bool diagonalDownSpecified
        {
            get
            {
                return this.diagonalDownFieldSpecified;
            }
            set
            {
                this.diagonalDownFieldSpecified = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool outline
        {
            get
            {
                return this.outlineField;
            }
            set
            {
                this.outlineField = value;
            }
        }
        internal static XmlSerializer serializer = new XmlSerializer(typeof(CT_Border));
        internal static XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces(new XmlQualifiedName[] {
            new XmlQualifiedName("", "http://schemas.openxmlformats.org/spreadsheetml/2006/main") });
        public override string ToString()
        {
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, this);
            return stringWriter.ToString();
        }
    }
}
