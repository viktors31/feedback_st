using FeedbackAPI.Models;
using System.Collections;

namespace FeedbackAPI.Interfaces
{
    public interface IContactRepository
    {
        public Task<IEnumerable> GetContacts();
        public void AddContact(Contact contact);
        public void DeleteContact(int id);
        public int GetContactByData(string name, string phone);
    }
}
