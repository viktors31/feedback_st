using AutoMapper;
using FeedbackAPI.Data;
using FeedbackAPI.Dto;
using FeedbackAPI.Interfaces;
using FeedbackAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IUnitOfWork u;
        private readonly IMapper mapper;
        public MessageController(IUnitOfWork u, IMapper mapper)
        {
            this.u = u;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetMessages()
        {
            var message_list = await u.MessageRepository.GetMessages();
            return Ok(message_list);
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> GetMessageById(int id)
        {
            var full_message = await u.MessageRepository.GetMessageById(id);
            return Ok(full_message);
        }
        [HttpPost]
        public async Task<IActionResult> AddMessage(MessagePostDto message)
        {
            //ищем контакт в бд
            int contactId = u.ContactRepository.GetContactByData(message.contactMail, message.contactPhone);
            if (contactId == -1)
            {
                var newContact = new Contact
                {
                    Name = message.contactName,
                    Phone = message.contactPhone,
                    Mail = message.contactMail,
                };
                u.ContactRepository.AddContact(newContact);
                u.Save();
                contactId = u.ContactRepository.GetContactByData(message.contactMail, message.contactPhone);
            }
            var newMessage = new Message
            {
                TopicId = message.topicId,
                ContactId = contactId,
                MessageText = message.MessageText,
                PostDate = DateTime.Now
            };
            u.MessageRepository.AddMessage(newMessage);
            await u.SaveAsync();
            return Ok(newMessage);
        }
    }
}
