﻿using Newtonsoft.Json;

namespace SampleProject.Shared.Extensions
{
    public static class JsonExtension
    {
        public static string TrySerializeObject(this object obj)
        {
            string result = null;

            if (obj is not null)
            {
                result = JsonConvert.SerializeObject(obj);
            }

            return result;
        }

        public static TModel TryDeserializeObject<TModel>(this string json, TModel defaultValue = null) where TModel : class
        {
            var result = defaultValue;

            if (!string.IsNullOrWhiteSpace(json))
            {
                result = JsonConvert.DeserializeObject<TModel>(json);
            }

            return result;
        }
    }
}
