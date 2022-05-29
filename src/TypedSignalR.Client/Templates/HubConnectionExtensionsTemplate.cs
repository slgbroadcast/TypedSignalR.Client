// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TypedSignalR.Client.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class HubConnectionExtensionsTemplate : HubConnectionExtensionsTemplateBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {

    static string CreateTypeParametersString(int num)
    {
        if (num <= 0)
        {
            return string.Empty;
        }

        var sb = new StringBuilder();

        sb.Append("T1");

        for (int i = 2; i <= num; i++)
        {
            sb.Append($", T{i}");
        }

        return sb.ToString();
    }

    static string CreateHandlerArgumentsString(int num)
    {
        if (num <= 0)
        {
            return string.Empty;
        }

        var sb = new StringBuilder();

        sb.Append("(T1)args[0]!");

        for (int i = 2; i <= num; i++)
        {
            sb.Append($", (T{i})args[{i - 1}]!");
        }

        return sb.ToString();
    }

            this.Write("// <auto-generated>\r\n// THIS (.cs) FILE IS GENERATED BY TypedSignalR.Client\r\n// <" +
                    "/auto-generated>\r\n#nullable enable\r\n#pragma warning disable CS1591\r\nnamespace Ty" +
                    "pedSignalR.Client\r\n{\r\n    public static partial class HubConnectionExtensions\r\n " +
                    "   {\r\n        public static THub CreateHubProxy<THub>(this global::Microsoft.Asp" +
                    "NetCore.SignalR.Client.HubConnection connection, global::System.Threading.Cancel" +
                    "lationToken cancellationToken = default)\r\n        {\r\n            var hubInvokerF" +
                    "actory = HubInvokerFactoryProvider.GetHubInvokerFactory<THub>();\r\n\r\n            " +
                    "if (hubInvokerFactory is null)\r\n            {\r\n                throw new global:" +
                    ":System.InvalidOperationException($\"Failed to create a hub proxy. TypedSignalR.C" +
                    "lient did not generate source code to create a hub proxy, which type is {typeof(" +
                    "THub)}.\");\r\n            }\r\n\r\n            return hubInvokerFactory.CreateHubInvok" +
                    "er(connection, cancellationToken);\r\n        }\r\n\r\n        public static global::S" +
                    "ystem.IDisposable Register<TReceiver>(this global::Microsoft.AspNetCore.SignalR." +
                    "Client.HubConnection connection, TReceiver receiver)\r\n        {\r\n            if " +
                    "(receiver is null)\r\n            {\r\n                throw new global::System.Argu" +
                    "mentNullException(nameof(receiver));\r\n            }\r\n\r\n            if (typeof(TR" +
                    "eceiver) == typeof(IHubConnectionObserver))\r\n            {\r\n#pragma warning disa" +
                    "ble CS8604\r\n                return new HubConnectionObserverSubscription(connect" +
                    "ion, receiver as IHubConnectionObserver);\r\n#pragma warning restore CS8604\r\n     " +
                    "       }\r\n\r\n            var binder = ReceiverBinderProvider.GetReceiverBinder<TR" +
                    "eceiver>();\r\n\r\n            if (binder is null)\r\n            {\r\n                t" +
                    "hrow new global::System.InvalidOperationException($\"Failed to register a receive" +
                    "r. TypedSignalR.Client did not generate source code to register a receiver, whic" +
                    "h type is {typeof(TReceiver)}.\");\r\n            }\r\n\r\n            var subscription" +
                    " = binder.Bind(connection, receiver);\r\n\r\n            if (receiver is IHubConnect" +
                    "ionObserver hubConnectionObserver)\r\n            {\r\n                subscription " +
                    "= new CompositeDisposable(new[] { subscription, new HubConnectionObserverSubscri" +
                    "ption(connection, hubConnectionObserver) });\r\n            }\r\n\r\n            retur" +
                    "n subscription;\r\n        }\r\n    }\r\n\r\n    public static partial class HubConnecti" +
                    "onExtensions\r\n    {\r\n        private static partial global::System.Collections.G" +
                    "eneric.Dictionary<global::System.Type, IHubInvokerFactory> CreateFactories();\r\n " +
                    "       private static partial global::System.Collections.Generic.Dictionary<glob" +
                    "al::System.Type, IReceiverBinder> CreateBinders();\r\n\r\n        private static cla" +
                    "ss HubInvokerFactoryProvider\r\n        {\r\n            private static global::Syst" +
                    "em.Collections.Generic.Dictionary<global::System.Type, IHubInvokerFactory> Facto" +
                    "ries;\r\n\r\n            static HubInvokerFactoryProvider()\r\n            {\r\n        " +
                    "        Factories = CreateFactories();\r\n            }\r\n\r\n            public stat" +
                    "ic IHubInvokerFactory<T>? GetHubInvokerFactory<T>()\r\n            {\r\n            " +
                    "    return Cache<T>.HubInvokerFactory;\r\n            }\r\n\r\n            private sta" +
                    "tic class Cache<T>\r\n            {\r\n                public static readonly IHubIn" +
                    "vokerFactory<T>? HubInvokerFactory = default;\r\n\r\n                static Cache()\r" +
                    "\n                {\r\n                    if (Factories.TryGetValue(typeof(T), out" +
                    " var hubInvokerFactory))\r\n                    {\r\n                        HubInvo" +
                    "kerFactory = hubInvokerFactory as IHubInvokerFactory<T>;\r\n                    }\r" +
                    "\n                }\r\n            }\r\n        }\r\n\r\n        private static class Rec" +
                    "eiverBinderProvider\r\n        {\r\n            private static global::System.Collec" +
                    "tions.Generic.Dictionary<global::System.Type, IReceiverBinder> Binders;\r\n\r\n     " +
                    "       static ReceiverBinderProvider()\r\n            {\r\n                Binders =" +
                    " CreateBinders();\r\n            }\r\n\r\n            public static IReceiverBinder<T>" +
                    "? GetReceiverBinder<T>()\r\n            {\r\n                return Cache<T>.Receive" +
                    "rBinder;\r\n            }\r\n\r\n            private static class Cache<T>\r\n          " +
                    "  {\r\n                public static readonly IReceiverBinder<T>? ReceiverBinder =" +
                    " default;\r\n\r\n                static Cache()\r\n                {\r\n                " +
                    "    if (Binders.TryGetValue(typeof(T), out var receiverBinder))\r\n               " +
                    "     {\r\n                        ReceiverBinder = receiverBinder as IReceiverBind" +
                    "er<T>;\r\n                    }\r\n                }\r\n            }\r\n        }\r\n\r\n  " +
                    "      private sealed class HubConnectionObserverSubscription : global::System.ID" +
                    "isposable\r\n        {\r\n            private readonly global::Microsoft.AspNetCore." +
                    "SignalR.Client.HubConnection _connection;\r\n            private readonly IHubConn" +
                    "ectionObserver _hubConnectionObserver;\r\n\r\n            private int _disposed = 0;" +
                    "\r\n\r\n            public HubConnectionObserverSubscription(global::Microsoft.AspNe" +
                    "tCore.SignalR.Client.HubConnection connection, IHubConnectionObserver hubConnect" +
                    "ionObserver)\r\n            {\r\n                _connection = connection;\r\n        " +
                    "        _hubConnectionObserver = hubConnectionObserver;\r\n\r\n                _conn" +
                    "ection.Closed += hubConnectionObserver.OnClosed;\r\n                _connection.Re" +
                    "connected += hubConnectionObserver.OnReconnected;\r\n                _connection.R" +
                    "econnecting += hubConnectionObserver.OnReconnecting;\r\n            }\r\n\r\n         " +
                    "   public void Dispose()\r\n            {\r\n                if (global::System.Thre" +
                    "ading.Interlocked.Exchange(ref _disposed, 1) == 0)\r\n                {\r\n         " +
                    "           _connection.Closed -= _hubConnectionObserver.OnClosed;\r\n             " +
                    "       _connection.Reconnected -= _hubConnectionObserver.OnReconnected;\r\n       " +
                    "             _connection.Reconnecting -= _hubConnectionObserver.OnReconnecting;\r" +
                    "\n                }\r\n            }\r\n        }\r\n\r\n        private sealed class Com" +
                    "positeDisposable : global::System.IDisposable\r\n        {\r\n            private re" +
                    "adonly object _gate = new object();\r\n            private readonly global::System" +
                    ".Collections.Generic.List<global::System.IDisposable> _disposables;\r\n\r\n         " +
                    "   private bool _disposed;\r\n\r\n            public CompositeDisposable()\r\n        " +
                    "    {\r\n                _disposables = new global::System.Collections.Generic.Lis" +
                    "t<global::System.IDisposable>();\r\n            }\r\n\r\n            public CompositeD" +
                    "isposable(global::System.IDisposable[] disposables)\r\n            {\r\n            " +
                    "    _disposables = new global::System.Collections.Generic.List<global::System.ID" +
                    "isposable>(disposables);\r\n            }\r\n\r\n            public CompositeDisposabl" +
                    "e(int capacity)\r\n            {\r\n                if (capacity < 0)\r\n             " +
                    "   {\r\n                    throw new global::System.ArgumentOutOfRangeException(n" +
                    "ameof(capacity));\r\n                }\r\n\r\n                _disposables = new globa" +
                    "l::System.Collections.Generic.List<global::System.IDisposable>(capacity);\r\n     " +
                    "       }\r\n\r\n            public void Add(global::System.IDisposable item)\r\n      " +
                    "      {\r\n                bool shouldDispose = false;\r\n\r\n                lock (_g" +
                    "ate)\r\n                {\r\n                    shouldDispose = _disposed;\r\n\r\n     " +
                    "               if (!_disposed)\r\n                    {\r\n                        _" +
                    "disposables.Add(item);\r\n                    }\r\n                }\r\n\r\n            " +
                    "    if (shouldDispose)\r\n                {\r\n                    item.Dispose();\r\n" +
                    "                }\r\n            }\r\n\r\n            public void Dispose()\r\n         " +
                    "   {\r\n                var currentDisposables = default(global::System.Collection" +
                    "s.Generic.List<global::System.IDisposable>);\r\n\r\n                lock (_gate)\r\n  " +
                    "              {\r\n                    if (_disposed)\r\n                    {\r\n    " +
                    "                    return;\r\n                    }\r\n\r\n                    _dispo" +
                    "sed = true;\r\n                    currentDisposables = _disposables;\r\n           " +
                    "     }\r\n\r\n                foreach (var item in currentDisposables)\r\n            " +
                    "    {\r\n                    if (item is not null)\r\n                    {\r\n       " +
                    "                 item.Dispose();\r\n                    }\r\n                }\r\n\r\n  " +
                    "              currentDisposables.Clear();\r\n            }\r\n        }\r\n\r\n        /" +
                    "/ It is not possible to avoid boxing.\r\n        // This is a limitation caused by" +
                    " the SignalR implementation.\r\n        private static class HandlerConverter\r\n   " +
                    "     {\r\n            public static global::System.Func<object?[], global::System." +
                    "Threading.Tasks.Task> Convert(global::System.Func<global::System.Threading.Tasks" +
                    ".Task> handler)\r\n            {\r\n                return args => handler();\r\n     " +
                    "       }\r\n");
 for(int i = 1; i <= 16; i++) { 
            this.Write("            \r\n            public static global::System.Func<object?[], global::Sy" +
                    "stem.Threading.Tasks.Task> Convert<");
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTypeParametersString(i)));
            this.Write(">(global::System.Func<");
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTypeParametersString(i)));
            this.Write(", global::System.Threading.Tasks.Task> handler)\r\n            {\r\n                r" +
                    "eturn args => handler(");
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateHandlerArgumentsString(i)));
            this.Write(");\r\n            }\r\n");
 } 
            this.Write("        }\r\n    }\r\n}\r\n#pragma warning restore CS1591\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class HubConnectionExtensionsTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
