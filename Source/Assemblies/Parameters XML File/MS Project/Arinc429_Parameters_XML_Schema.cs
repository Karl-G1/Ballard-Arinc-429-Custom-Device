﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class parameters {
    
    private parametersChannel[] channelField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("channel")]
    public parametersChannel[] channel {
        get {
            return this.channelField;
        }
        set {
            this.channelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class parametersChannel {
    
    private int hardwareChannelField;
    
    private parametersChannelLabel[] labelField;
    
    /// <remarks/>
    public int hardwareChannel {
        get {
            return this.hardwareChannelField;
        }
        set {
            this.hardwareChannelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("label")]
    public parametersChannelLabel[] label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class parametersChannelLabel {
    
    private int labelDecimalField;
    
    private bool labelDecimalFieldSpecified;
    
    private int labelOctalField;
    
    private bool labelOctalFieldSpecified;
    
    private parametersChannelLabelSdi sdiField;
    
    private bool createSDIChannelField;
    
    private bool createSSMChannelField;
    
    private bool createParityChannelField;
    
    private parametersChannelLabelParameter[] parameterField;
    
    public parametersChannelLabel() {
        this.sdiField = parametersChannelLabelSdi.All;
        this.createSDIChannelField = false;
        this.createSSMChannelField = false;
        this.createParityChannelField = false;
    }
    
    /// <remarks/>
    public int labelDecimal {
        get {
            return this.labelDecimalField;
        }
        set {
            this.labelDecimalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool labelDecimalSpecified {
        get {
            return this.labelDecimalFieldSpecified;
        }
        set {
            this.labelDecimalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public int labelOctal {
        get {
            return this.labelOctalField;
        }
        set {
            this.labelOctalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool labelOctalSpecified {
        get {
            return this.labelOctalFieldSpecified;
        }
        set {
            this.labelOctalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(parametersChannelLabelSdi.All)]
    public parametersChannelLabelSdi sdi {
        get {
            return this.sdiField;
        }
        set {
            this.sdiField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool createSDIChannel {
        get {
            return this.createSDIChannelField;
        }
        set {
            this.createSDIChannelField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool createSSMChannel {
        get {
            return this.createSSMChannelField;
        }
        set {
            this.createSSMChannelField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool createParityChannel {
        get {
            return this.createParityChannelField;
        }
        set {
            this.createParityChannelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameter")]
    public parametersChannelLabelParameter[] parameter {
        get {
            return this.parameterField;
        }
        set {
            this.parameterField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum parametersChannelLabelSdi {
    
    /// <remarks/>
    All,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("00")]
    Item00,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class parametersChannelLabelParameter {
    
    private object[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("defaultValue", typeof(double))]
    [System.Xml.Serialization.XmlElementAttribute("encoding", typeof(parametersChannelLabelParameterEncoding))]
    [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("numberOfBits", typeof(int))]
    [System.Xml.Serialization.XmlElementAttribute("offset", typeof(double))]
    [System.Xml.Serialization.XmlElementAttribute("scale", typeof(double))]
    [System.Xml.Serialization.XmlElementAttribute("signed", typeof(bool))]
    [System.Xml.Serialization.XmlElementAttribute("startBit", typeof(int))]
    [System.Xml.Serialization.XmlElementAttribute("unit", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum parametersChannelLabelParameterEncoding {
    
    /// <remarks/>
    BNR,
    
    /// <remarks/>
    BCD,
    
    /// <remarks/>
    Discrete,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    defaultValue,
    
    /// <remarks/>
    encoding,
    
    /// <remarks/>
    name,
    
    /// <remarks/>
    numberOfBits,
    
    /// <remarks/>
    offset,
    
    /// <remarks/>
    scale,
    
    /// <remarks/>
    signed,
    
    /// <remarks/>
    startBit,
    
    /// <remarks/>
    unit,
}