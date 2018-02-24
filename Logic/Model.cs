using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SimpleBot.Logic
{
    public class Model : MongoClient
    {
        public Model() {

            Model cliente = new Model();

            var db = cliente.GetDatabase("Bot");
            var col = db.GetCollection<BsonDocument>("teste");

          
    }


        public void InserirDados()
        {

        }


    }
}