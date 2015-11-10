// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The get account batch arg object</para>
    /// </summary>
    public class GetAccountBatchArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetAccountBatchArg> Encoder = new GetAccountBatchArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetAccountBatchArg> Decoder = new GetAccountBatchArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetAccountBatchArg" />
        /// class.</para>
        /// </summary>
        /// <param name="accountIds">List of user account identifiers.  Should not contain any
        /// duplicate account IDs.</param>
        public GetAccountBatchArg(col.IEnumerable<string> accountIds)
        {
            var accountIdsList = new col.List<string>(accountIds ?? new string[0]);

            if (accountIds == null)
            {
                throw new sys.ArgumentNullException("accountIds");
            }
            else if (accountIdsList.Count < 1)
            {
                throw new sys.ArgumentOutOfRangeException("accountIds");
            }

            this.AccountIds = accountIdsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetAccountBatchArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetAccountBatchArg()
        {
        }

        /// <summary>
        /// <para>List of user account identifiers.  Should not contain any duplicate account
        /// IDs.</para>
        /// </summary>
        public col.IList<string> AccountIds { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetAccountBatchArg" />.</para>
        /// </summary>
        private class GetAccountBatchArgEncoder : enc.StructEncoder<GetAccountBatchArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetAccountBatchArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("account_ids", value.AccountIds, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetAccountBatchArg" />.</para>
        /// </summary>
        private class GetAccountBatchArgDecoder : enc.StructDecoder<GetAccountBatchArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetAccountBatchArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetAccountBatchArg Create()
            {
                return new GetAccountBatchArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetAccountBatchArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "account_ids":
                        value.AccountIds = ReadList(reader, enc.StringDecoder.Instance);
                        break;
                    default:
                        SkipProperty(reader);
                        break;
                }
            }
        }

        #endregion
    }
}
