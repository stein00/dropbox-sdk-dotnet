// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Properties
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The property field object</para>
    /// </summary>
    public class PropertyField
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PropertyField> Encoder = new PropertyFieldEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PropertyField> Decoder = new PropertyFieldDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PropertyField" /> class.</para>
        /// </summary>
        /// <param name="name">This is the name or key of a custom property in a property
        /// template. File property names can be up to 256 bytes.</param>
        /// <param name="value">Value of a custom property attached to a file. Values can be up
        /// to 1024 bytes.</param>
        public PropertyField(string name,
                             string @value)
        {
            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (@value == null)
            {
                throw new sys.ArgumentNullException("@value");
            }

            this.Name = name;
            this.Value = @value;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PropertyField" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public PropertyField()
        {
        }

        /// <summary>
        /// <para>This is the name or key of a custom property in a property template. File
        /// property names can be up to 256 bytes.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Value of a custom property attached to a file. Values can be up to 1024
        /// bytes.</para>
        /// </summary>
        public string Value { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PropertyField" />.</para>
        /// </summary>
        private class PropertyFieldEncoder : enc.StructEncoder<PropertyField>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PropertyField value, enc.IJsonWriter writer)
            {
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("value", value.Value, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PropertyField" />.</para>
        /// </summary>
        private class PropertyFieldDecoder : enc.StructDecoder<PropertyField>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PropertyField" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PropertyField Create()
            {
                return new PropertyField();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PropertyField value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "value":
                        value.Value = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
