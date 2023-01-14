using System;
using System.Drawing;
using System.Threading;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Vision_Client.discord
{
	// Token: 0x02000020 RID: 32
	internal class Account
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001DD90 File Offset: 0x0001DD90
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0001DD98 File Offset: 0x0001DD98
		public string _id { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001DDA1 File Offset: 0x0001DDA1
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0001DDA9 File Offset: 0x0001DDA9
		public string _name { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0001DDB2 File Offset: 0x0001DDB2
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0001DDBA File Offset: 0x0001DDBA
		public string _avatarUrl { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0001DDC3 File Offset: 0x0001DDC3
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0001DDCB File Offset: 0x0001DDCB
		public Role _role { get; set; }

		// Token: 0x060001BB RID: 443 RVA: 0x0001DDD4 File Offset: 0x0001DDD4
		public Account(string id, string name, string avatarUrl, Role role)
		{
			this._id = id;
			this._name = name;
			this._avatarUrl = avatarUrl;
			this._role = role;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001DE00 File Offset: 0x0001DE00
		public static Account getAccountFromUUID(string uuid)
		{
			MongoClientSettings mongoClientSettings = MongoClientSettings.FromConnectionString("mongodb+srv://vision_client:FX4u9AtZ0Q7IRKu9@cluster0.46hvc.mongodb.net/?retryWrites=true&w=majority");
			mongoClientSettings.ServerApi = new ServerApi(ServerApiVersion.V1, default(Optional<bool?>), default(Optional<bool?>));
			MongoClient mongoClient = new MongoClient(mongoClientSettings);
			IMongoDatabase database = mongoClient.GetDatabase("vision", null);
			IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("clients", null);
			FilterDefinitionBuilder<BsonDocument> filter = Builders<BsonDocument>.Filter;
			FilterDefinition<BsonDocument> filterDefinition = filter.Eq<string>("uuid", uuid);
			BsonDocument bsonDocument = BsonExtensionMethods.ToBsonDocument<BsonDocument>(IFindFluentExtensions.First<BsonDocument, BsonDocument>(IMongoCollectionExtensions.Find<BsonDocument>(collection, filterDefinition, null), default(CancellationToken)), null, null, default(BsonSerializationArgs));
			bool flag = bsonDocument != null;
			Account result;
			if (flag)
			{
				Color color = Color.FromArgb(bsonDocument.GetElement("color-red").Value.AsInt32, bsonDocument.GetElement("color-green").Value.AsInt32, bsonDocument.GetElement("color-blue").Value.AsInt32, bsonDocument.GetElement("color-alpha").Value.AsInt32);
				result = new Account(uuid, bsonDocument.GetElement("user").Value.AsString, bsonDocument.GetElement("avatar-url").Value.AsString, new Role(bsonDocument.GetElement("role").Value.AsString, color));
			}
			else
			{
				result = null;
			}
			return result;
		}
	}
}
