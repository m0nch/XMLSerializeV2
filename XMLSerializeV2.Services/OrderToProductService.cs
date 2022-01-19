using XMLSerializeV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using XMLSerializeV2.Data.DB;
using System.Linq;

namespace XMLSerializeV2.Services
{
    internal class OrderToProductService : IOrderToProductService
    {
        private readonly IFileManager<OrderToProduct> _fileManager;
        private readonly IFileManager<Product> _fileManagerProduct;
        private readonly IFileManager<Order> _fileManagerOrder;

        public OrderToProductService(
                    IFileManager<OrderToProduct> fileManager, 
                    IFileManager<Product> fileManagerProduct,
                    IFileManager<Order> fileManagerOrder)
        {
            _fileManager = fileManager;
            _fileManagerProduct = fileManagerProduct;
            _fileManagerOrder = fileManagerOrder;
        }
        public void Add(OrderToProduct model)
        {
            List<OrderToProduct> orderToProducts = _fileManager.Read(_fileManager.XmlOrderToProduct);
            orderToProducts.Add(model);
            _fileManager.Write(orderToProducts, _fileManager.XmlOrderToProduct);
        }
        public void Remove(Guid id)
        {
            List<OrderToProduct> orderToProducts = _fileManager.Read(_fileManager.XmlOrderToProduct);
            OrderToProduct orderToProduct = orderToProducts.FirstOrDefault(x => x.ProductId == id);
            orderToProducts.Remove(orderToProduct);
            _fileManager.Write(orderToProducts, _fileManager.XmlOrderToProduct);
        }
        public void RemoveAll(Guid id)
        {
            List<OrderToProduct> orderToProducts = _fileManager.Read(_fileManager.XmlOrderToProduct);
            OrderToProduct orderToProduct = orderToProducts.FirstOrDefault(x => x.OrderId == id);
            orderToProducts.Remove(orderToProduct);
            _fileManager.Write(orderToProducts, _fileManager.XmlOrderToProduct);
        }
        public List<Product> GetAllByOrder(Guid id)
        {
            List<OrderToProduct> o2pList = _fileManager.Read(_fileManager.XmlOrderToProduct).FindAll(x=>x.OrderId == id);
            List<Product> products = _fileManagerProduct.Read(_fileManager.XmlProduct);
            List<Product> productByOrder = new List<Product>();
            foreach (var item in o2pList)
            {
                Product product = products.FirstOrDefault(x => x.Id == item.ProductId);
                productByOrder.Add(product);
            }
            return productByOrder;
        }
        public List<Order> GetAllByProduct(Guid id)
        {
            List<OrderToProduct> o2pList = _fileManager.Read(_fileManager.XmlOrderToProduct).FindAll(x=>x.ProductId == id);
            List<Order> orders = _fileManagerOrder.Read(_fileManager.XmlOrder);
            List<Order> orderByProduct = new List<Order>();
            foreach (var item in o2pList)
            {
                Order order = orders.FirstOrDefault(x => x.Id == item.OrderId);
                orderByProduct.Add(order);
            }
            return orderByProduct;
        }
    }
}
