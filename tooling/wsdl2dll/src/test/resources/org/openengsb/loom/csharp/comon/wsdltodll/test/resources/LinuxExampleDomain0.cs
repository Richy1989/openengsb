/**
 * Licensed to the Austrian Association for Software Tool Integration (AASTI)
 * under one or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information regarding copyright
 * ownership. The AASTI licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
// This source code was auto-generated by Web Services Description Language Utility
//Mono Framework v4.0.30319.1
//


/// <remarks/>
[System.Web.Services.WebServiceAttribute(Namespace="http://example.domain.openengsb.org/")]
[System.Web.Services.WebServiceBinding(Name="ExampleDomainPort", Namespace="http://example.domain.openengsb.org/")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Event))]
public abstract partial class ExampleDomain : System.Web.Services.WebService {
    
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example.domain.openengsb.org/", ResponseNamespace="http://example.domain.openengsb.org/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public abstract string doSomethingWithLogEvent(LogEvent arg0);
    
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example.domain.openengsb.org/", ResponseNamespace="http://example.domain.openengsb.org/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public abstract string getInstanceId();
    
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example.domain.openengsb.org/", ResponseNamespace="http://example.domain.openengsb.org/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public abstract AliveState getAliveState();
    
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example.domain.openengsb.org/", ResponseNamespace="http://example.domain.openengsb.org/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public abstract string doSomethingWithMessage([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string arg0);
    
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example.domain.openengsb.org/", ResponseNamespace="http://example.domain.openengsb.org/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return")]
    public abstract ExampleResponseModel doSomethingWithModel(ExampleRequestModel arg0);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://event.example.domain.openengsb.org")]
public partial class LogEvent : Event {
    
    private string levelField;
    
    private string messageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string level {
        get {
            return this.levelField;
        }
        set {
            this.levelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.core.openengsb.org")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LogEvent))]
public partial class Event {
    
    private string nameField;
    
    private string originField;
    
    private System.Nullable<long> processIdField;
    
    private bool processIdSpecifiedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string origin {
        get {
            return this.originField;
        }
        set {
            this.originField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, DataType="long")]
    public System.Nullable<long> processId {
        get {
            return this.processIdField;
        }
        set {
            this.processIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public virtual bool processIdSpecified {
        get {
            return this.processIdSpecifiedField;
        }
        set {
            this.processIdSpecifiedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.core.openengsb.org")]
public enum AliveState {
    
    /// <remarks/>
    CONNECTING,
    
    /// <remarks/>
    ONLINE,
    
    /// <remarks/>
    OFFLINE,
    
    /// <remarks/>
    DISCONNECTED,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://model.example.domain.openengsb.org")]
public partial class ExampleRequestModel {
    
    private System.Nullable<int> idField;
    
    private bool idSpecifiedField;
    
    private string nameField1;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, DataType="int")]
    public System.Nullable<int> id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public virtual bool idSpecified {
        get {
            return this.idSpecifiedField;
        }
        set {
            this.idSpecifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string name {
        get {
            return this.nameField1;
        }
        set {
            this.nameField1 = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://model.example.domain.openengsb.org")]
public partial class ExampleResponseModel {
    
    private string resultField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
}
