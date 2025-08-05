

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
public class Question
{   
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    
    [BsonElement("questionText")]
    public string? QuestionText { get; set; }

    [BsonElement("choices")]
    public string[]? Choices { get; set; }

    [BsonElement("tag")]
    public string? Tag { get; set; }

    [BsonElement("correctAnswer")]
    public string? CorrectAnswer { get; set; }

}