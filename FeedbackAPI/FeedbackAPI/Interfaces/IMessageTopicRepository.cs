using FeedbackAPI.Models;
using System.Collections;

namespace FeedbackAPI.Interfaces
{
    public interface IMessageTopicRepository
    {
        public Task<IEnumerable> GetMessageTopics();
        public void AddMessageTopic(MessageTopic topic);
        public void DeleteMessageTopic(string topicName);
    }
}
