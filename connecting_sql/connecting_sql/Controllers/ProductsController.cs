using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using connecting_sql.Models;

namespace connecting_sql.Controllers
{
    public class ProductsController : Controller
    {
        string cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True";

        
        public ActionResult Index()
        {
            List<Products> productList = new List<Products>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    productList.Add(new Products
                    {
                        Id = Convert.ToInt32(rd["ProductId"]),     
                        Name = rd["ProductName"].ToString(),       
                        Quantity = Convert.ToInt32(rd["Quantity"]),
                        Price = Convert.ToSingle(rd["Price"])
                    });
                }
            }

            return View("Home",productList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products prod)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "INSERT INTO Products (ProductName, Quantity, Price) VALUES (@ProductName, @Quantity, @Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductName", prod.Name);
                cmd.Parameters.AddWithValue("@Quantity", prod.Quantity);
                cmd.Parameters.AddWithValue("@Price", prod.Price);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Products prod = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Products WHERE ProductId = @ProductId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductId", id);

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    prod = new Products
                    {
                        Id = Convert.ToInt32(rd["ProductId"]),
                        Name = rd["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(rd["Quantity"]),
                        Price = Convert.ToSingle(rd["Price"])
                    };
                }
            }

            if (prod == null)
            {
                return HttpNotFound();
            }

            return View(prod);
        }

        [HttpPost]
        public ActionResult Edit(Products prod)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "UPDATE Products SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price WHERE ProductId = @ProductId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductId", prod.Id);
                cmd.Parameters.AddWithValue("@ProductName", prod.Name);
                cmd.Parameters.AddWithValue("@Quantity", prod.Quantity);
                cmd.Parameters.AddWithValue("@Price", prod.Price);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE FROM Products WHERE ProductId = @ProductId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductId", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }
    }
}