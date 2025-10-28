using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

// Переконайся, що простір імен правильний
namespace SubscriptionManager.Core.Models
{
    /// <summary>
    /// Модель реалізує сповіщення, які отримує користувач про підписку
    /// </summary>
    public class MessageItem
    {
        /// <summary>
        /// Унікальний ідентифікатор повідомлення
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// Заголовок повідомлення
        /// </summary>
        [BsonElement("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Кому надсилається повідомлення (ID користувача)
        /// </summary>
        [BsonElement("ownerId")]
        [BsonRepresentation(BsonType.ObjectId)] // Додано для консистентності з іншими ID
        public string? OwnerId { get; set; }

        /// <summary>
        /// Ідентифікатор підписки, до якої відноситься повідомлення
        /// </summary>
        [BsonElement("subId")]
        [BsonRepresentation(BsonType.ObjectId)] // Додано для консистентності з іншими ID
        public string? SubId { get; set; }
    }
}