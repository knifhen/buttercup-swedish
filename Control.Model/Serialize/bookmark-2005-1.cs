﻿////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by a tool.
////     Runtime Version:2.0.50727.3053
////
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------

//using System.Xml.Serialization;

//// 
//// This source code was auto-generated by xsd, Version=2.0.50727.1432.
//// 


///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class bookmarkSet {
    
//    private title titleField;
    
//    private string uidField;
    
//    private lastmark lastmarkField;
    
//    private object[] itemsField;
    
//    /// <remarks/>
//    public title title {
//        get {
//            return this.titleField;
//        }
//        set {
//            this.titleField = value;
//        }
//    }
    
//    /// <remarks/>
//    public string uid {
//        get {
//            return this.uidField;
//        }
//        set {
//            this.uidField = value;
//        }
//    }
    
//    /// <remarks/>
//    public lastmark lastmark {
//        get {
//            return this.lastmarkField;
//        }
//        set {
//            this.lastmarkField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark))]
//    [System.Xml.Serialization.XmlElementAttribute("hilite", typeof(hilite))]
//    public object[] Items {
//        get {
//            return this.itemsField;
//        }
//        set {
//            this.itemsField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class title {
    
//    private string textField;
    
//    private audio audioField;
    
//    /// <remarks/>
//    public string text {
//        get {
//            return this.textField;
//        }
//        set {
//            this.textField = value;
//        }
//    }
    
//    /// <remarks/>
//    public audio audio {
//        get {
//            return this.audioField;
//        }
//        set {
//            this.audioField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class audio {
    
//    private string srcField;
    
//    private string clipBeginField;
    
//    private string clipEndField;
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string src {
//        get {
//            return this.srcField;
//        }
//        set {
//            this.srcField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string clipBegin {
//        get {
//            return this.clipBeginField;
//        }
//        set {
//            this.clipBeginField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string clipEnd {
//        get {
//            return this.clipEndField;
//        }
//        set {
//            this.clipEndField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class lastmark {
    
//    private string ncxRefField;
    
//    private string uRIField;
    
//    private string[] itemsField;
    
//    private ItemsChoiceType[] itemsElementNameField;
    
//    /// <remarks/>
//    public string ncxRef {
//        get {
//            return this.ncxRefField;
//        }
//        set {
//            this.ncxRefField = value;
//        }
//    }
    
//    /// <remarks/>
//    public string URI {
//        get {
//            return this.uRIField;
//        }
//        set {
//            this.uRIField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("charOffset", typeof(string))]
//    [System.Xml.Serialization.XmlElementAttribute("timeOffset", typeof(string))]
//    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//    public string[] Items {
//        get {
//            return this.itemsField;
//        }
//        set {
//            this.itemsField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//    [System.Xml.Serialization.XmlIgnoreAttribute()]
//    public ItemsChoiceType[] ItemsElementName {
//        get {
//            return this.itemsElementNameField;
//        }
//        set {
//            this.itemsElementNameField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IncludeInSchema=false)]
//public enum ItemsChoiceType {
    
//    /// <remarks/>
//    charOffset,
    
//    /// <remarks/>
//    timeOffset,
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class bookmark {
    
//    private string ncxRefField;
    
//    private string uRIField;
    
//    private string[] itemsField;
    
//    private ItemsChoiceType1[] itemsElementNameField;
    
//    private note noteField;
    
//    private string labelField;
    
//    private string langField;
    
//    /// <remarks/>
//    public string ncxRef {
//        get {
//            return this.ncxRefField;
//        }
//        set {
//            this.ncxRefField = value;
//        }
//    }
    
//    /// <remarks/>
//    public string URI {
//        get {
//            return this.uRIField;
//        }
//        set {
//            this.uRIField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("charOffset", typeof(string))]
//    [System.Xml.Serialization.XmlElementAttribute("timeOffset", typeof(string))]
//    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//    public string[] Items {
//        get {
//            return this.itemsField;
//        }
//        set {
//            this.itemsField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//    [System.Xml.Serialization.XmlIgnoreAttribute()]
//    public ItemsChoiceType1[] ItemsElementName {
//        get {
//            return this.itemsElementNameField;
//        }
//        set {
//            this.itemsElementNameField = value;
//        }
//    }
    
//    /// <remarks/>
//    public note note {
//        get {
//            return this.noteField;
//        }
//        set {
//            this.noteField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string label {
//        get {
//            return this.labelField;
//        }
//        set {
//            this.labelField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
//    public string lang {
//        get {
//            return this.langField;
//        }
//        set {
//            this.langField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IncludeInSchema=false)]
//public enum ItemsChoiceType1 {
    
//    /// <remarks/>
//    charOffset,
    
//    /// <remarks/>
//    timeOffset,
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class note {
    
//    private string textField;
    
//    private audio audioField;
    
//    /// <remarks/>
//    public string text {
//        get {
//            return this.textField;
//        }
//        set {
//            this.textField = value;
//        }
//    }
    
//    /// <remarks/>
//    public audio audio {
//        get {
//            return this.audioField;
//        }
//        set {
//            this.audioField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class hilite {
    
//    private hiliteStart hiliteStartField;
    
//    private hiliteEnd hiliteEndField;
    
//    private note noteField;
    
//    private string labelField;
    
//    /// <remarks/>
//    public hiliteStart hiliteStart {
//        get {
//            return this.hiliteStartField;
//        }
//        set {
//            this.hiliteStartField = value;
//        }
//    }
    
//    /// <remarks/>
//    public hiliteEnd hiliteEnd {
//        get {
//            return this.hiliteEndField;
//        }
//        set {
//            this.hiliteEndField = value;
//        }
//    }
    
//    /// <remarks/>
//    public note note {
//        get {
//            return this.noteField;
//        }
//        set {
//            this.noteField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string label {
//        get {
//            return this.labelField;
//        }
//        set {
//            this.labelField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class hiliteStart {
    
//    private string ncxRefField;
    
//    private string uRIField;
    
//    private string[] itemsField;
    
//    private ItemsChoiceType2[] itemsElementNameField;
    
//    /// <remarks/>
//    public string ncxRef {
//        get {
//            return this.ncxRefField;
//        }
//        set {
//            this.ncxRefField = value;
//        }
//    }
    
//    /// <remarks/>
//    public string URI {
//        get {
//            return this.uRIField;
//        }
//        set {
//            this.uRIField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("charOffset", typeof(string))]
//    [System.Xml.Serialization.XmlElementAttribute("timeOffset", typeof(string))]
//    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//    public string[] Items {
//        get {
//            return this.itemsField;
//        }
//        set {
//            this.itemsField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//    [System.Xml.Serialization.XmlIgnoreAttribute()]
//    public ItemsChoiceType2[] ItemsElementName {
//        get {
//            return this.itemsElementNameField;
//        }
//        set {
//            this.itemsElementNameField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IncludeInSchema=false)]
//public enum ItemsChoiceType2 {
    
//    /// <remarks/>
//    charOffset,
    
//    /// <remarks/>
//    timeOffset,
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/bookmark-2005-1")]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IsNullable=false)]
//public partial class hiliteEnd {
    
//    private string ncxRefField;
    
//    private string uRIField;
    
//    private string[] itemsField;
    
//    private ItemsChoiceType3[] itemsElementNameField;
    
//    /// <remarks/>
//    public string ncxRef {
//        get {
//            return this.ncxRefField;
//        }
//        set {
//            this.ncxRefField = value;
//        }
//    }
    
//    /// <remarks/>
//    public string URI {
//        get {
//            return this.uRIField;
//        }
//        set {
//            this.uRIField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("charOffset", typeof(string))]
//    [System.Xml.Serialization.XmlElementAttribute("timeOffset", typeof(string))]
//    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//    public string[] Items {
//        get {
//            return this.itemsField;
//        }
//        set {
//            this.itemsField = value;
//        }
//    }
    
//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//    [System.Xml.Serialization.XmlIgnoreAttribute()]
//    public ItemsChoiceType3[] ItemsElementName {
//        get {
//            return this.itemsElementNameField;
//        }
//        set {
//            this.itemsElementNameField = value;
//        }
//    }
//}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//[System.SerializableAttribute()]
//[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/bookmark-2005-1", IncludeInSchema=false)]
//public enum ItemsChoiceType3 {
    
//    /// <remarks/>
//    charOffset,
    
//    /// <remarks/>
//    timeOffset,
//}
