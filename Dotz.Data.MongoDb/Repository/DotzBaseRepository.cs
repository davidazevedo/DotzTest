using Dotz.Data.MongoDb.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;

namespace Dotz.Data.MongoDb.Repository
{
    public class DotzBaseRepository  : IDotzBaseRepository
    {
        public readonly MongoClient _client;
        public readonly MongoServer _server;
        public readonly MongoDatabase _db;

        public DotzBaseRepository()
        {
            _client = new MongoClient("mongodb://localhost:27017");
#pragma warning disable CS0618 // Type or member is obsolete
            _server = _client.GetServer();
#pragma warning restore CS0618 // Type or member is obsolete
            _db = _server.GetDatabase("DotzDb");
        }
    }
}
