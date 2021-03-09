﻿using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace SportsStore.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value) =>
            session.SetString(key, JsonSerializer.Serialize(value));

        public static T GetJson<T>(this ISession session, string key) =>
            session.GetString(key) == null
                ? default(T)
                : JsonSerializer.Deserialize<T>(session.GetString(key));
    }
}
