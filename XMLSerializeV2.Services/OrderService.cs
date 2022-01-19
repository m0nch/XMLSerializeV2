using XMLSerializeV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using XMLSerializeV2.Data.DB;
using System.Linq;

namespace XMLSerializeV2.Services
{
    internal class OrderService : IOrderService
    {
        private readonly IFileManager<Order> _fileManager;

        public OrderService(IFileManager<Order> fileManager)
        {
            _fileManager = fileManager;
        }
        public void Add(Order model)
        {
            List<Order> orders = _fileManager.Read(_fileManager.XmlOrder);
            orders.Add(model);
            _fileManager.Write(orders, _fileManager.XmlOrder);
        }
        public Order Get(Guid id)
        {
            Order order = _fileManager.Read(_fileManager.XmlOrder).FirstOrDefault(x => x.Id == id);
            return order;
        }
        public List<Order> GetAll()
        {
            return _fileManager.Read(_fileManager.XmlOrder);
        }
        public void Remove(Guid id)
        {
            List<Order> orders = _fileManager.Read(_fileManager.XmlOrder);
            Order order = orders.FirstOrDefault(x => x.Id == id);
            orders.Remove(order);
            _fileManager.Write(orders, _fileManager.XmlOrder);
        }
        public void Update(Order model)
        {
            List<Order> orders = _fileManager.Read(_fileManager.XmlOrder);
            Order order = orders.FirstOrDefault(t => t.Id == model.Id);
            int index = orders.IndexOf(order);
            orders[index] = model;
            _fileManager.Write(orders, _fileManager.XmlOrder);
        }
    }
}
