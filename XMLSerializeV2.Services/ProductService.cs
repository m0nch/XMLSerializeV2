using XMLSerializeV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using XMLSerializeV2.Data.DB;
using System.Linq;

namespace XMLSerializeV2.Services
{
    internal class ProductService : IProductService
    {
        private readonly IFileManager<Product> _fileManager;
        public ProductService(IFileManager<Product> fileManager)
        {
            _fileManager = fileManager;
        }

        public void Add(Product model)
        {
            List<Product> products = _fileManager.Read(_fileManager.XmlProduct);
            products.Add(model);
            _fileManager.Write(products, _fileManager.XmlProduct);
        }

        public Product Get(Guid id)
        {
            return _fileManager.Read(_fileManager.XmlProduct).FirstOrDefault(x => x.Id == id) as Product;
        }
        public List<Product> GetAll()
        {
            return _fileManager.Read(_fileManager.XmlProduct);
        }
        public void Remove(Guid id)
        {
            List<Product> products = _fileManager.Read(_fileManager.XmlProduct);
            Product product = products.FirstOrDefault(x => x.Id == id);
            products.Remove(product);
            _fileManager.Write(products, _fileManager.XmlProduct);
        }

        public void Update(Product model)
        {
            List<Product> products = _fileManager.Read(_fileManager.XmlProduct);
            Product product = products.FirstOrDefault(t => t.Id == model.Id);
            int index = products.IndexOf(product);
            products[index] = model;
            _fileManager.Write(products, _fileManager.XmlProduct);
        }
    }
}
