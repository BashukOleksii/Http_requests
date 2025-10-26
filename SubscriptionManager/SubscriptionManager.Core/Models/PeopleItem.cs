using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionManager.Core.Models
{
    /// <summary>
    /// Моедль що представляє користувачів програми для управління підписками
    /// </summary>
    public class PeopleItem
    {
        /// <summary>
        /// Унікальний ідентифікатор
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        /// <summary>
        /// Ім'я або логін користувача
        /// </summary>
        [BsonElement("name")]
        public string? Name { get; set; }
        /// <summary>
        /// Поштова адреса користувача
        /// </summary>
        [BsonElement("email")]
        public string? Email { get; set; }

    }
}
