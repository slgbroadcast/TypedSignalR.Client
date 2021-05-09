﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TypedSignalR.Client
{
    public class MethodInfo
    {
        public string MethodName { get; }
        public string ReturnValueType { get; }
        public IReadOnlyList<(string typeName, string argName)> Args { get; }

        public bool IsGenericTypeReturn { get; }
        public string ReturnTypeGenericArg { get; }

        public string ArgParameterToString()
        {
            if (Args.Count == 0)
            {
                return string.Empty;
            }

            if (Args.Count == 1)
            {
                return $"{Args[0].typeName} {Args[0].argName}";
            }

            var sb = new StringBuilder();

            for (int i = 0; i < Args.Count - 1; i++)
            {
                sb.Append(Args[i].typeName);
                sb.Append(' ');
                sb.Append(Args[i].argName);
                sb.Append(',');
            }

            sb.Append(Args[Args.Count - 1].typeName);
            sb.Append(' ');
            sb.Append(Args[Args.Count - 1].argName);
            return sb.ToString();
        }

        public string ArgNamesParameterToOneline()
        {
            if (Args.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            foreach (var arg in Args)
            {
                sb.Append(',');
                sb.Append(arg.argName);
            }

            return sb.ToString();
        }

        public string ArgTypesParameterToOneline()
        {
            if (Args.Count == 0)
            {
                return string.Empty;
            }

            if (Args.Count == 1)
            {
                return $"<{Args[0].typeName}>";
            }

            var sb = new StringBuilder();
            sb.Append('<');

            for (int i = 0; i < Args.Count - 1; i++)
            {
                sb.Append(Args[i].typeName);
                sb.Append(',');
            }

            sb.Append(Args[Args.Count - 1].typeName);
            sb.Append('>');
            return sb.ToString();
        }

        public string ReturnTypeGenericArgToString()
        {
            return IsGenericTypeReturn ? $"<{ReturnTypeGenericArg}>" : string.Empty;
        }

        /// <param name="isGenericTypeReturn">if return type is Task<T>, must be true. </param>
        /// <param name="returnTypeArg">e.g. if return type is Task<Datetime>, you must be input System.Datetime </param>
        public MethodInfo(string methodName, string returnValueType, IReadOnlyList<(string typeName, string argName)> args, bool isGenericTypeReturn, string returnTypeGenericArg)
        {
            MethodName = methodName;
            ReturnValueType = returnValueType;
            Args = args;
            IsGenericTypeReturn = isGenericTypeReturn;
            ReturnTypeGenericArg = returnTypeGenericArg;
        }
    }
}