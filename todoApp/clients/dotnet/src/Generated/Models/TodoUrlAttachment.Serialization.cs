// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Todo;

namespace Todo.Models
{
    /// <summary></summary>
    public partial class TodoUrlAttachment : IJsonModel<TodoUrlAttachment>
    {
        internal TodoUrlAttachment()
        {
        }

        void IJsonModel<TodoUrlAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoUrlAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoUrlAttachment)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url.AbsoluteUri);
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        TodoUrlAttachment IJsonModel<TodoUrlAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoUrlAttachment JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoUrlAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoUrlAttachment)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTodoUrlAttachment(document.RootElement, options);
        }

        internal static TodoUrlAttachment DeserializeTodoUrlAttachment(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            Uri url = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("description"u8))
                {
                    description = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("url"u8))
                {
                    url = new Uri(prop.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new TodoUrlAttachment(description, url, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<TodoUrlAttachment>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoUrlAttachment>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TodoUrlAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        TodoUrlAttachment IPersistableModel<TodoUrlAttachment>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoUrlAttachment PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoUrlAttachment>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeTodoUrlAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TodoUrlAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TodoUrlAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="todoUrlAttachment"> The <see cref="TodoUrlAttachment"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(TodoUrlAttachment todoUrlAttachment)
        {
            if (todoUrlAttachment == null)
            {
                return null;
            }
            return BinaryContent.Create(todoUrlAttachment, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="TodoUrlAttachment"/> from. </param>
        public static explicit operator TodoUrlAttachment(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeTodoUrlAttachment(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}