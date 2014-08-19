﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RSA_WebService

{
    
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "AdministradorRSAWSPortBinding", Namespace = "http://banrep.gov.co/s3")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(mensajeBase))]
    public partial class AdministradorRSAWS : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback autenticarRSAOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public AdministradorRSAWS()
        {
            this.Url = global:: RSA_WebService.Properties.Resources.URL;
            //this.Url = global::SSO_GAD.Properties.Settings.Default.SSO_GAD_co_gov_banrep_osb_AdministradorRSAWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event autenticarRSACompletedEventHandler autenticarRSACompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("autenticarRSA", RequestNamespace = "http://banrep.gov.co/s3", ResponseNamespace = "http://banrep.gov.co/s3", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public respuestaWSAutenticarUsuarioRSA autenticarRSA([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] peticionWSAutenticarUsuarioRSA datosPeticion)
        {
            /*
            object[] results = this.Invoke("autenticarRSA", new object[] {
                        datosPeticion});
            return ((respuestaWSAutenticarUsuarioRSA)(results[0]));
             */
            RSAGLT rsa = new RSAGLT();
            
            respuestaWSAutenticarUsuarioRSA resp= new respuestaWSAutenticarUsuarioRSA();
            resp.resultado= rsa.TokenExist(datosPeticion.usuario, datosPeticion.passCode);
            return resp;

        }

        /// <remarks/>
        public void autenticarRSAAsync(peticionWSAutenticarUsuarioRSA datosPeticion)
        {
            this.autenticarRSAAsync(datosPeticion, null);
        }

        /// <remarks/>
        public void autenticarRSAAsync(peticionWSAutenticarUsuarioRSA datosPeticion, object userState)
        {
            if ((this.autenticarRSAOperationCompleted == null))
            {
                this.autenticarRSAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnautenticarRSAOperationCompleted);
            }
            this.InvokeAsync("autenticarRSA", new object[] {
                        datosPeticion}, this.autenticarRSAOperationCompleted, userState);
        }

        private void OnautenticarRSAOperationCompleted(object arg)
        {
            if ((this.autenticarRSACompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.autenticarRSACompleted(this, new autenticarRSACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://banrep.gov.co/s3")]
    public partial class peticionWSAutenticarUsuarioRSA
    {

        private string idSesionField;

        private string passCodeField;

        private string usuarioField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idSesion
        {
            get
            {
                return this.idSesionField;
            }
            set
            {
                this.idSesionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string passCode
        {
            get
            {
                return this.passCodeField;
            }
            set
            {
                this.passCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario
        {
            get
            {
                return this.usuarioField;
            }
            set
            {
                this.usuarioField = value;
            }
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(respuestaWSAutenticarUsuarioRSA))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://banrep.gov.co/s3")]
    public partial class mensajeBase
    {

        private int codigoRespuestaField;

        private string descripcionField;

        private string idMensajeField;

        private string ipPeticionField;

        private string operacionField;

        private string origenField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codigoRespuesta
        {
            get
            {
                return this.codigoRespuestaField;
            }
            set
            {
                this.codigoRespuestaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idMensaje
        {
            get
            {
                return this.idMensajeField;
            }
            set
            {
                this.idMensajeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ipPeticion
        {
            get
            {
                return this.ipPeticionField;
            }
            set
            {
                this.ipPeticionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string operacion
        {
            get
            {
                return this.operacionField;
            }
            set
            {
                this.operacionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string origen
        {
            get
            {
                return this.origenField;
            }
            set
            {
                this.origenField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://banrep.gov.co/s3")]
    public partial class respuestaWSAutenticarUsuarioRSA : mensajeBase
    {

        private string idSesionField;

        private bool resultadoField;

        private string usuarioField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idSesion
        {
            get
            {
                return this.idSesionField;
            }
            set
            {
                this.idSesionField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool resultado
        {
            get
            {
                return this.resultadoField;
            }
            set
            {
                this.resultadoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario
        {
            get
            {
                return this.usuarioField;
            }
            set
            {
                this.usuarioField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void autenticarRSACompletedEventHandler(object sender, autenticarRSACompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class autenticarRSACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal autenticarRSACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public respuestaWSAutenticarUsuarioRSA Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((respuestaWSAutenticarUsuarioRSA)(this.results[0]));
            }
        }
    }
}

