using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using XMLSerializeV2.Data.Models;
using XMLSerializeV2.Services;

namespace XMLSerializeV2
{
    public partial class MainForm : Form
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IOrderToProductService _orderToProductService;
        private OrderForm _orderForm;
        private readonly _IAppCache _appCache;

        public MainForm(
            IProductService productService,
            IOrderService orderService,
            IOrderToProductService orderToProductService,
            OrderForm orderForm,
            _IAppCache appCache)
        {
            InitializeComponent();

            _productService = productService;
            _orderService = orderService;
            _orderToProductService = orderToProductService;
            _orderForm = orderForm;
            _appCache = appCache;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            grdProducts.AutoGenerateColumns = false;
            grdOrders.AutoGenerateColumns = false;
            RefreshProducts();
            RefreshOrders();
        }
        private void btnAddPrd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtNamePrd.Text,
                Price = Convert.ToDecimal(txtPricePrd.Text)
            };
            _productService.Add(product);
            RefreshProducts();
        }
        private void btnRemovePrd_Click(object sender, EventArgs e)
        {
            Product product = _productService.Get(Guid.Parse(grdProducts.SelectedRows[0].Cells["prdId"].Value.ToString()));
            Guid id = product.Id;
            _productService.Remove(id); //
            RefreshProducts();
        }
        private void btnUpdatePrd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Guid.Parse(lblGuidPrd.Text),
                Name = txtNamePrd.Text,
                Price = Convert.ToDecimal(txtPricePrd.Text)
            };
            _productService.Update(product);
            RefreshProducts();
        }
        private void grdProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdId.Text = grdProducts.SelectedRows[0].Cells["prdId"].Value.ToString();
            ShowRowProduct();
        }
        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrdId.Text = grdOrders.SelectedRows[0].Cells["ordId"].Value.ToString();
            ShowRowOrder();
        }

        private void btnAddOrd_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                Name = txtNameOrd.Text,
            };
            _orderService.Add(order);
            RefreshOrders();
        }
        private void btnRemoveOrd_Click(object sender, EventArgs e)
        {
            Order order = _orderService.Get(Guid.Parse(grdOrders.SelectedRows[0].Cells["ordId"].Value.ToString()));
            Guid id = order.Id;
            _orderService.Remove(id);
            _orderToProductService.RemoveAll(id);
            RefreshOrders();
        }
        private void btnUpdateOrd_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                Id = Guid.Parse(lblGuidOrd.Text),
                Name = txtNameOrd.Text,
            };
            _orderService.Update(order);
            RefreshOrders();
        }
        private void RefreshProducts()
        {
            grdProducts.DataSource = null;
            grdProducts.DataSource = _productService.GetAll();
            if (grdProducts.Rows.Count > 0)
            {
                grdProducts.Rows[0].Selected = true;
            }
            ShowRowProduct();
        }
        private void ShowRowProduct()
        {
            if (grdProducts.SelectedRows.Count > 0)
            {
                lblGuidPrd.Visible = true;
                lblGuidPrd.Text = grdProducts.SelectedRows[0].Cells["prdId"].Value.ToString();
                txtNamePrd.Text = grdProducts.SelectedRows[0].Cells["prdName"].Value.ToString();
                txtPricePrd.Text = grdProducts.SelectedRows[0].Cells["prdPrice"].Value.ToString();
            }
        }
        private void RefreshOrders()
        {
            grdOrders.DataSource = null;
            grdOrders.DataSource = _orderService.GetAll();
            if (grdOrders.SelectedRows.Count > 0)
            {
                grdOrders.Rows[0].Selected = true;
            }
            ShowRowOrder();
        }
        private void ShowRowOrder()
        {
            if (grdOrders.SelectedRows.Count > 0)
            {
                lblIdOrd.Visible = true; lblGuidOrd.Visible = true;
                lblGuidOrd.Text = grdOrders.SelectedRows[0].Cells["ordId"].Value.ToString();
                txtNameOrd.Text = grdOrders.SelectedRows[0].Cells["ordName"].Value.ToString();
            }
            else
            {
                lblIdOrd.Visible = false; lblGuidOrd.Visible = false;
                lblIdOrd.Text = "";
                lblGuidOrd.Text = "";
                txtNameOrd.Text = "";
            }
        }

        private void grdOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var obj = ((DataGridView)sender).SelectedRows[0].Cells["ordId"].Value;
                var objName = ((DataGridView)sender).SelectedRows[0].Cells["ordName"].Value;

                if (!_appCache._ViewBag.ContainsValue(obj))
                {
                    _appCache._ViewBag.Add("OrderId", obj);
                    _appCache._ViewBag.Add("OrderName", objName);
                }
                _orderForm.ShowDialog();
                _orderForm.Activate();
            }

        }

        private void btnFindProdInOrd_Click(object sender, EventArgs e)
        {
            if (txtProdId.Text.Length > 0)
            {
                Guid id = Guid.Parse(txtProdId.Text);
                grdOrders.DataSource = _orderToProductService.GetAllByProduct(id);
            }
            else return;
        }

        private void btnFind_Leave(object sender, EventArgs e)
        {
            txtProdId.Clear();
            RefreshOrders();
        }

        private void btnFindOrdProds_Click(object sender, EventArgs e)
        {
            if (txtOrdId.Text.Length > 0)
            {
                Guid id = Guid.Parse(txtOrdId.Text);
                grdProducts.DataSource = _orderToProductService.GetAllByOrder(id);
            }
            else return;

        }

        private void btnFindOrdProds_Leave(object sender, EventArgs e)
        {
            txtOrdId.Clear();
            RefreshProducts();
        }
    }
}
