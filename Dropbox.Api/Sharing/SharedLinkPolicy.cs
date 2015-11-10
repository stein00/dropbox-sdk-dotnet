// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Policy governing who can view shared links.</para>
    /// </summary>
    public class SharedLinkPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedLinkPolicy> Encoder = new SharedLinkPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedLinkPolicy> Decoder = new SharedLinkPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkPolicy" />
        /// class.</para>
        /// </summary>
        public SharedLinkPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Anyone</para>
        /// </summary>
        public bool IsAnyone
        {
            get
            {
                return this is Anyone;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Anyone, or <c>null</c>.</para>
        /// </summary>
        public Anyone AsAnyone
        {
            get
            {
                return this as Anyone;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Members</para>
        /// </summary>
        public bool IsMembers
        {
            get
            {
                return this is Members;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Members, or <c>null</c>.</para>
        /// </summary>
        public Members AsMembers
        {
            get
            {
                return this as Members;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedLinkPolicy" />.</para>
        /// </summary>
        private class SharedLinkPolicyEncoder : enc.StructEncoder<SharedLinkPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedLinkPolicy value, enc.IJsonWriter writer)
            {
                if (value is Anyone)
                {
                    WriteProperty(".tag", "anyone", writer, enc.StringEncoder.Instance);
                    Anyone.Encoder.EncodeFields((Anyone)value, writer);
                    return;
                }
                if (value is Members)
                {
                    WriteProperty(".tag", "members", writer, enc.StringEncoder.Instance);
                    Members.Encoder.EncodeFields((Members)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedLinkPolicy" />.</para>
        /// </summary>
        private class SharedLinkPolicyDecoder : enc.UnionDecoder<SharedLinkPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedLinkPolicy" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedLinkPolicy Create()
            {
                return new SharedLinkPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SharedLinkPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "anyone":
                        return Anyone.Decoder.DecodeFields(reader);
                    case "members":
                        return Members.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Links can be shared with anyone.</para>
        /// </summary>
        public sealed class Anyone : SharedLinkPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Anyone> Encoder = new AnyoneEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Anyone> Decoder = new AnyoneDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Anyone" /> class.</para>
            /// </summary>
            private Anyone()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Anyone</para>
            /// </summary>
            public static readonly Anyone Instance = new Anyone();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Anyone" />.</para>
            /// </summary>
            private class AnyoneEncoder : enc.StructEncoder<Anyone>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Anyone value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Anyone" />.</para>
            /// </summary>
            private class AnyoneDecoder : enc.StructDecoder<Anyone>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Anyone" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Anyone Create()
                {
                    return new Anyone();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Anyone DecodeFields(enc.IJsonReader reader)
                {
                    return Anyone.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Links can only be shared among members of the shared folder.</para>
        /// </summary>
        public sealed class Members : SharedLinkPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Members> Encoder = new MembersEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Members> Decoder = new MembersDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Members" /> class.</para>
            /// </summary>
            private Members()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Members</para>
            /// </summary>
            public static readonly Members Instance = new Members();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Members" />.</para>
            /// </summary>
            private class MembersEncoder : enc.StructEncoder<Members>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Members value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Members" />.</para>
            /// </summary>
            private class MembersDecoder : enc.StructDecoder<Members>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Members" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Members Create()
                {
                    return new Members();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Members DecodeFields(enc.IJsonReader reader)
                {
                    return Members.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>An unknown shared link policy.</para>
        /// </summary>
        public sealed class Other : SharedLinkPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
