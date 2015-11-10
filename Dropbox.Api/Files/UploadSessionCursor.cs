// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The upload session cursor object</para>
    /// </summary>
    /// <seealso cref="UploadSessionFinishArg" />
    public class UploadSessionCursor
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionCursor> Encoder = new UploadSessionCursorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionCursor> Decoder = new UploadSessionCursorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionCursor" />
        /// class.</para>
        /// </summary>
        /// <param name="sessionId">The upload session ID (returned by <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.UploadSessionStartAsync" />).</param>
        /// <param name="offset">The amount of data that has been uploaded so far. We use this
        /// to make sure upload data isn't lost or duplicated in the event of a network
        /// error.</param>
        public UploadSessionCursor(string sessionId,
                                   ulong offset)
        {
            if (sessionId == null)
            {
                throw new sys.ArgumentNullException("sessionId");
            }

            this.SessionId = sessionId;
            this.Offset = offset;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionCursor" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UploadSessionCursor()
        {
        }

        /// <summary>
        /// <para>The upload session ID (returned by <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.UploadSessionStartAsync" />).</para>
        /// </summary>
        public string SessionId { get; protected set; }

        /// <summary>
        /// <para>The amount of data that has been uploaded so far. We use this to make sure
        /// upload data isn't lost or duplicated in the event of a network error.</para>
        /// </summary>
        public ulong Offset { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionCursor" />.</para>
        /// </summary>
        private class UploadSessionCursorEncoder : enc.StructEncoder<UploadSessionCursor>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionCursor value, enc.IJsonWriter writer)
            {
                WriteProperty("session_id", value.SessionId, writer, enc.StringEncoder.Instance);
                WriteProperty("offset", value.Offset, writer, enc.UInt64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionCursor" />.</para>
        /// </summary>
        private class UploadSessionCursorDecoder : enc.StructDecoder<UploadSessionCursor>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionCursor" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionCursor Create()
            {
                return new UploadSessionCursor();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadSessionCursor value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "session_id":
                        value.SessionId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "offset":
                        value.Offset = enc.UInt64Decoder.Instance.Decode(reader);
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
