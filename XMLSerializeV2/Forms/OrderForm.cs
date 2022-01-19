using XMLSerializeV2.Data.Models;
using XMLSerializeV2.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace XMLSerializeV2
{
    public partial class OrderForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IOrderToProductService _orderToProductService;
        private readonly _IAppCache _appCache;

        public OrderForm(
            IOrderService orderService,
            IProductService productService,
            IOrderToProductService orderToProductService,
            _IAppCache appCache)
        {
            InitializeComponent();
            _orderService = orderService;
            _productService = productService;
            _orderToProductService = orderToProductService;
            _appCache = appCache;
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            lblGuid.Visible = true;
            lblGuid.Text = _appCache._ViewBag["OrderId"].ToString();
            lblNameOrd.Visible = true;
            lblNameOrd.Text = _appCache._ViewBag["OrderName"].ToString();

            FillListBox();

            grdProductsInOrder.AutoGenerateColumns = false;
            grdProductsInOrder.DataSource = _orderToProductService.GetAllByOrder((Guid)_appCache._ViewBag["OrderId"]);
            //if (grdProductsInOrder.Rows.Count > 0)
            //{
            //    grdProductsInOrder.Rows[0].Selected = true;
            //    if (grdProductsInOrder.SelectedRows.Count > 0)
            //    {
            //        RefreshOrders();
            //    }
            //}
        }

        private void FillListBox()
        {
            lstBoxProd.Items.Clear();
            List<Product> products = _productService.GetAll();
            foreach (var item in products)
            {
                lstBoxProd.Items.Add($"{item.Name}  {item.Price}AMD   {item.Id}");
            }
        }

        private void SecondForm_Activated(object sender, EventArgs e)
        {
            FillListBox();
            RefreshOrders();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Product> products = _productService.GetAll();
            foreach (var item in lstBoxProd.CheckedItems)
            {
                foreach (var prod in products)
                {
                    var id = prod.Id.ToString();
                    if (item.ToString().Contains(id))
                    {
                        OrderToProduct o2p = new OrderToProduct()
                        {
                            OrderId = (Guid)_appCache._ViewBag["OrderId"],
                            ProductId = prod.Id
                        };
                        _orderToProductService.Add(o2p);
                    }
                }
            }
            RefreshOrders();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Product product = _productService.Get(Guid.Parse(grdProductsInOrder.SelectedRows[0].Cells["Id"].Value.ToString()));
            Guid id = product.Id;
            _orderToProductService.Remove(id); 
        }
        private void RefreshOrders()
        {
            grdProductsInOrder.DataSource = null;
            grdProductsInOrder.DataSource = _orderToProductService.GetAllByOrder((Guid)_appCache._ViewBag["OrderId"]);
            if (grdProductsInOrder.SelectedRows.Count > 0)
            {
                grdProductsInOrder.Rows[0].Selected = true;
            }
        }
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _appCache._ViewBag.Remove("OrderId");
            _appCache._ViewBag.Remove("OrderName");
        }
    }
}
