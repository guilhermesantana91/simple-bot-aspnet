using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SimpleBot
{
    public class SimpleBotUser
    {
        public static string Reply(Message message)
        {
            var cliente = new MongoClient();
            var db = cliente.GetDatabase("bot");
            var col = db.GetCollection<BsonDocument>("historico");

            var doc = new BsonDocument
            {
                {"Texto",message.Text},
                {"Usuario",message.User}
            };

            col.InsertOne(doc);

            return $"{message.User} disse '{message.Text}'";

        }

        public static UserProfile GetProfile(string id)
        {
            return null;
        }

        public static void SetProfile(string id, UserProfile profile)
        {
        }
    }
}